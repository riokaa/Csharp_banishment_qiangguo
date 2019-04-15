using Banishment.Modules;
using Banishment.NetWork;
using Banishment.WebOptions;
using CefSharp;
using System;
using System.Threading;

namespace Banishment.BaseLib {
    public class ThreadsController {
        private Thread threadCheckUpdate;
        private Thread threadMain;
        private Thread threadNoVoice;
        private Thread threadProMouseMove;
        private Thread threadProScroll;

        public ThreadsController() {
            threadMain = new Thread(Logic.Start);
            threadProMouseMove = new Thread(WebAction.ProMouseMove);
            threadProScroll = new Thread(WebAction.ProScroll);
            threadCheckUpdate = new Thread(CheckVersion.Start);
            threadNoVoice = new Thread(NoVoice);
        }
        public void ThreadCheckUpdateStart() {
            if (threadCheckUpdate.ThreadState == ThreadState.Unstarted) {
                threadCheckUpdate.Start();
            } else if (threadCheckUpdate.ThreadState == ThreadState.Aborted) {
                threadCheckUpdate = new Thread(CheckVersion.Start);
                threadCheckUpdate.Start();
            }
        }
        public void ThreadMainStart() {
            if(threadMain.ThreadState == ThreadState.Unstarted) {
                threadMain.Start();
            }else if(threadMain.ThreadState == ThreadState.Aborted) {
                threadMain = new Thread(Logic.Start);
                threadMain.Start();
            }
        }
        public void ThreadMainAbort() {
            if(threadMain.ThreadState != ThreadState.Unstarted && threadMain.ThreadState != ThreadState.Aborted) {
                threadMain.Abort();
            }
        }
        public void ThreadNoVoiceStart() {
            if (threadNoVoice.ThreadState == ThreadState.Unstarted) {
                threadNoVoice.Start();
            } else if (threadNoVoice.ThreadState == ThreadState.Aborted) {
                threadNoVoice = new Thread(NoVoice);
                threadNoVoice.Start();
            }
        }
        public void ThreadNoVoiceAbort() {
            if (threadNoVoice.ThreadState != ThreadState.Unstarted && threadNoVoice.ThreadState != ThreadState.Aborted) {
                threadNoVoice.Abort();
            }
        }
        public void ThreadProMouseMoveResume() {
            switch (threadProMouseMove.ThreadState) {
                case ThreadState.Unstarted:
                    threadProMouseMove.Start();
                    break;
                case ThreadState.Suspended:
#pragma warning disable CS0618 // 类型或成员已过时
                    threadProMouseMove.Resume();
#pragma warning restore CS0618 // 类型或成员已过时
                    break;
            }
        }
        public void ThreadProMouseMoveSuspend() {
            if (threadProMouseMove.ThreadState == ThreadState.WaitSleepJoin || threadProMouseMove.ThreadState == ThreadState.Running) {
#pragma warning disable CS0618 // 类型或成员已过时
                threadProMouseMove.Suspend();
#pragma warning restore CS0618 // 类型或成员已过时
            }
        }
        public void ThreadProScrollResume() {
            switch (threadProScroll.ThreadState) {
                case ThreadState.Unstarted:
                    threadProScroll.Start();
                    break;
                case ThreadState.Suspended:
#pragma warning disable CS0618 // 类型或成员已过时
                    threadProScroll.Resume();
#pragma warning restore CS0618 // 类型或成员已过时
                    break;
            }
        }
        public void ThreadProScrollSuspend() {
            if (threadProScroll.ThreadState == ThreadState.WaitSleepJoin || threadProScroll.ThreadState == ThreadState.Running) {
#pragma warning disable CS0618 // 类型或成员已过时
                threadProScroll.Suspend();
#pragma warning restore CS0618 // 类型或成员已过时
            }
        }

        /// <summary>
        /// 静音线程方法
        /// </summary>
        private void NoVoice() {
            var browser = MainForm.self.MainWeb;
            while (true) {
                if(BS.vip && Const.settingsNoVoice && MainForm.self.browserInitialized) {
                    if (browser.InvokeRequired) {
                        browser.Invoke(new Action(() => {
                            browser.EvaluateScriptAsync("document.getElementsByTagName(\'audio\')[0].volume = 0;");
                        }));
                    } else {
                        browser.EvaluateScriptAsync("document.getElementsByTagName(\'audio\')[0].volume = 0;");
                    }
                }
                Thread.Sleep(500);
            }
        }
    }
}
