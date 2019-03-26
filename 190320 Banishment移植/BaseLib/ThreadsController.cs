using _190320_Banishment移植.Modules;
using _190320_Banishment移植.WebOptions;
using System.Threading;

namespace _190320_Banishment移植.BaseLib {
    public class ThreadsController {
        private Thread threadMain;
        private Thread threadProMouseMove;
        private Thread threadProScroll;

        public ThreadsController() {
            threadMain = new Thread(Logic.Start);
            threadProMouseMove = new Thread(WebAction.ProMouseMove);
            threadProScroll = new Thread(WebAction.ProScroll);
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
    }
}
