using System.IO;
using System;
using System.Drawing;
using System.Reflection;

namespace BanishmentImageDll{
    public class Src{
        private static Stream Get(string str) {
            switch (str) {
                case "Cloud":
                    return GetCloudRandomly();
                case "MainIcon":
                    return Assembly.GetExecutingAssembly().GetManifestResourceStream("BanishmentImageDll.Resources.MainIcon.ico");
                case "MainIcon360":
                    return Assembly.GetExecutingAssembly().GetManifestResourceStream("BanishmentImageDll.Resources.MainIcon360.ico");
                case "Rikka":
                    return Assembly.GetExecutingAssembly().GetManifestResourceStream("BanishmentImageDll.Resources.Rikka.png");
                default:
                    return Assembly.GetExecutingAssembly().GetManifestResourceStream("BanishmentImageDll.Resources.Rikka.png");
            }
        }
        private static Stream GetCloudRandomly() {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Format("BanishmentImageDll.Resources.clouds.cloud_{0}.png", new Random().Next(1, 7)));
        }
        public static Icon GetIcon(string str) {
            return Convert.ImageToIcon(Image.FromStream(Get(str)));
        }
        public static Image GetImage(string str) {
            return Image.FromStream(Get(str));
        }
    }
}
