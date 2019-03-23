﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Reflection;
using System.IO;

namespace _190320_Banishment移植.BaseLib {

    /// <summary>
    ///JsonTableHelper 的摘要说明
    /// </summary>

    public static class JsonTableHelper {
        /// <summary> 
        /// 返回对象序列化 
        /// </summary> 
        /// <param name="obj">源对象</param> 
        /// <returns>json数据</returns> 
        public static string ToJson(this object obj) {
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            return serialize.Serialize(obj);
        }

        /// <summary> 
        /// 控制深度 
        /// </summary> 
        /// <param name="obj">源对象</param> 
        /// <param name="recursionDepth">深度</param> 
        /// <returns>json数据</returns> 
        public static string ToJson(this object obj, int recursionDepth) {
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            serialize.RecursionLimit = recursionDepth;
            return serialize.Serialize(obj);
        }

        /// <summary> 
        /// DataTable转为json 
        /// </summary> 
        /// <param name="dt">DataTable</param> 
        /// <returns>json数据</returns> 
        public static string ToJson(DataTable dt) {
            StringBuilder jsonString = new StringBuilder();
            jsonString.Append("[");
            DataRowCollection drc = dt.Rows;
            for (int i = 0; i < drc.Count; i++) {
                jsonString.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++) {
                    string strKey = dt.Columns[j].ColumnName;
                    string strValue = drc[i][j].ToString();

                    Type type = dt.Columns[j].DataType;
                    jsonString.Append("\"" + strKey + "\":");
                    strValue = StringFormat(strValue, type);
                    if (j < dt.Columns.Count - 1) {
                        jsonString.Append(strValue + ",");
                    } else {
                        jsonString.Append(strValue);
                    }
                }
                jsonString.Append("},");
            }
            jsonString.Remove(jsonString.Length - 1, 1);
            jsonString.Append("]");
            return jsonString.ToString();
        }




        /// <summary>    
        /// 格式化字符型、日期型、布尔型    
        /// </summary>    
        /// <param name="str"></param>    
        /// <param name="type"></param>    
        /// <returns></returns>    
        private static string StringFormat(string str, Type type) {
            if (str == null || str == string.Empty)
                str = "\"\"";
            if (type == typeof(string)) {
                str = String2Json(str);
                str = "\"" + str + "\"";
            } else if (type == typeof(DateTime)) {
                str = "\"" + str + "\"";
            } else if (type == typeof(bool)) {
                str = str.ToLower();
            }
            return str;
        }
        /// <summary> 
        /// DataTable转为json,不带索引 
        /// </summary> 
        /// <param name="dt">DataTable</param> 
        /// <returns>json数据</returns> 
        public static string ToJsonTotal(DataTable dt, int count) {

            StringBuilder sb = new StringBuilder();
            sb.Append("{\"total\":" + count + ",\"rows\":");
            sb.Append(ToJsonp(dt));
            sb.Append("}");
            return sb.ToString();
        }
        /// <summary>    
        /// 过滤特殊字符    
        /// </summary>    
        /// <param name="s"></param>    
        /// <returns></returns>    
        private static string String2Json(String s) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++) {
                char c = s.ToCharArray()[i];
                switch (c) {
                    case '\"':
                        sb.Append("\\\""); break;
                    case '\\':
                        sb.Append("\\\\"); break;
                    case '/':
                        sb.Append("\\/"); break;
                    case '\b':
                        sb.Append("\\b"); break;
                    case '\f':
                        sb.Append("\\f"); break;
                    case '\n':
                        sb.Append("\\n"); break;
                    case '\r':
                        sb.Append("\\r"); break;
                    case '\t':
                        sb.Append("\\t"); break;
                    default:
                        sb.Append(c); break;
                }
            }
            return sb.ToString();
        }
        /// <summary> 
        /// DataTable转为json 
        /// </summary> 
        /// <param name="dt">DataTable</param> 
        /// <returns>json数据</returns> 
        public static string ToJsonDrv(DataTable dt) {
            Dictionary<string, object> dic = new Dictionary<string, object>();

            int index = 0;
            foreach (DataRowView drv in dt.DefaultView) {
                Dictionary<string, object> result = new Dictionary<string, object>();

                foreach (DataColumn dc in dt.Columns) {
                    result.Add(dc.ColumnName, drv[dc.ColumnName].ToString());
                }
                dic.Add(index.ToString(), result);
                index++;
            }
            return ToJson(dic);
        }
        /// <summary> 
        /// DataTable转为jsonp,autocomplete插件需要使用的jsonp格式 
        /// </summary> 
        /// <param name="dtResult">DataTable</param> 
        /// <returns>jsonp数据</returns> 
        public static string ToJsonp(DataTable dtResult) {
            if (dtResult == null) {
                return "";
            }

            StringBuilder jsonString = new StringBuilder();

            string temp = "";
            string value = "";
            jsonString.Append("[");

            foreach (DataRow dr in dtResult.Rows) {
                temp = "";

                jsonString.Append("{");

                foreach (DataColumn dc in dtResult.Columns) {
                    value = dr[dc].ToString();

                    //if (value.Length < 1)
                    //{
                    //    value = " ";
                    //}

                    temp += "\"" + dc.ColumnName + "\":\"" + value + "\",";
                }

                temp = temp.TrimEnd(',');

                jsonString.Append(temp + "},");
            }

            temp = jsonString.ToString();
            temp = temp.TrimEnd(',');
            temp += "]";

            return temp;
        }

        /// <summary> 
        /// 将实体类转换成DataTable 
        /// </summary> 
        /// <typeparam name="T"></typeparam> 
        /// <param name="i_objlist"></param> 
        /// <returns></returns> 
        public static DataTable ToDataTable<T>(IList<T> objlist) {
            if (objlist == null || objlist.Count <= 0) {
                return null;
            }
            DataTable dt = new DataTable(typeof(T).Name);
            DataColumn column;
            DataRow row;

            System.Reflection.PropertyInfo[] myPropertyInfo = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (T t in objlist) {
                if (t == null) {
                    continue;
                }

                row = dt.NewRow();

                for (int i = 0, j = myPropertyInfo.Length; i < j; i++) {
                    System.Reflection.PropertyInfo pi = myPropertyInfo[i];

                    string name = pi.Name;

                    if (dt.Columns[name] == null) {
                        column = new DataColumn(name, pi.PropertyType);
                        dt.Columns.Add(column);
                    }

                    row[name] = pi.GetValue(t, null);
                }

                dt.Rows.Add(row);
            }
            return dt;
        }

        public static string Obj2Base64String(object serializableObject) {
            string returnedData;
            if (serializableObject == null)
                returnedData = String.Empty;
            else {
                byte[] resultBytes = null;
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter
                         = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                formatter.Serialize(stream, serializableObject);
                resultBytes = stream.ToArray();
                stream.Close();
                returnedData = Convert.ToBase64String(resultBytes);
            }
            return returnedData;
        }

        ///<summary></summary> <summary><summary></summary>   
        /// Deserializes base64 string to object.返序列化string 为 object    
        /// </summary><summary></summary>    
        public static object Base64String2Obj(string deserializedString) {
            object returnedData;
            if (deserializedString == String.Empty)
                returnedData = null;
            else {
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter
                       = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                byte[] middata = Convert.FromBase64String(deserializedString);
                stream.Write(middata, 0, middata.Length);
                //Pay attention to the following line. don't forget this line.    
                stream.Seek(0, SeekOrigin.Begin);
                returnedData = formatter.Deserialize(stream);
                stream.Close();
            }
            return returnedData;
        }
        /// <summary>
        /// Json 字符串 转换为 DataTable数据集合
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static DataTable ToDataTable(this string json) {
            DataTable dataTable = new DataTable();  //实例化
            DataTable result;
            try {
                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值
                ArrayList arrayList = javaScriptSerializer.Deserialize<ArrayList>(json);
                if (arrayList.Count > 0) {
                    foreach (Dictionary<string, object> dictionary in arrayList) {
                        if (dictionary.Keys.Count<string>() == 0) {
                            result = dataTable;
                            return result;
                        }
                        if (dataTable.Columns.Count == 0) {
                            foreach (string current in dictionary.Keys) {
                                dataTable.Columns.Add(current, dictionary[current].GetType());
                            }
                        }
                        DataRow dataRow = dataTable.NewRow();
                        foreach (string current in dictionary.Keys) {
                            dataRow[current] = dictionary[current];
                        }

                        dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
                    }
                }
            } catch {
            }
            result = dataTable;
            return result;
        }
    }
}
