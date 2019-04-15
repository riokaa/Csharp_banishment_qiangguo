using BanishmentImageDll.Properties;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Reflection;

namespace BanishmentImageDll{
    public class Src{
        public Stream Get(string str) {
            switch (str) {
                case "Cloud":
                    return GetCloudRandomly();
                case "MainIcon":
                    return this.GetType().Assembly.GetManifestResourceStream("MainIcon.ico");
                    //return Resources.MainIcon;
                case "MainIcon360":
                    return this.GetType().Assembly.GetManifestResourceStream("MainIcon360.ico");
                //return Resources.MainIcon360;
                case "MainIconImage":
                    return this.GetType().Assembly.GetManifestResourceStream("MainIconImage.png");
                //return Resources.MainIconImage;
                case "Rikka":
                    return this.GetType().Assembly.GetManifestResourceStream("Rikka.png");
                //return Resources.Rikka;
                default:
                    return this.GetType().Assembly.GetManifestResourceStream("Rikka.png");
                    //return Resources.Rikka;
            }
        }
        private Stream GetCloudRandomly() {

            return this.GetType().Assembly.GetManifestResourceStream(string.Format("cloud_{0}.png", new Random().Next(1, 7)));
            //switch (new Random().Next(1, 7)) {
            //    case 1:
            //        return Resources.cloud_1;
            //    case 2:
            //        return Resources.cloud_2;
            //    case 3:
            //        return Resources.cloud_3;
            //    case 4:
            //        return Resources.cloud_4;
            //    case 5:
            //        return Resources.cloud_5;
            //    case 6:
            //        return Resources.cloud_6;
            //}
            //return Resources.cloud_1;
        }
    }
}
