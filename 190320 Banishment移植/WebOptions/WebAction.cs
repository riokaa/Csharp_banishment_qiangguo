﻿using BanishmentVerifyDll;
using System;
using System.Threading;

namespace Banishment.WebOptions {
    class WebAction {
        public static void ProMouseMove() {
            //TODO
        }
        public static void ProScroll() {
            Random random = new Random();
            while (true) {
                if (BS.vip) { //pro
                    Thread.Sleep(1000 * random.Next(1, 16));
                    WebLib.ScrollTo(0, (random.Next(0, 2) * 2 - 1) * random.Next(20, 300) + 20, 1);
                } else {
                    Thread.Sleep(2000);
                    WebLib.ScrollTo(0, (random.Next(0, 2) * 2 - 1) * 50 + 5, 1);
                }
            }
        }
    }
}
