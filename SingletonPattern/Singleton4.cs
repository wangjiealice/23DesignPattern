/*
4、双检锁/双重校验锁（DCL，即 double-checked locking）
JDK 版本：JDK1.5 起

是否 Lazy 初始化：是

是否多线程安全：是

实现难度：较复杂

描述：这种方式采用双锁机制，安全且在多线程情况下能保持高性能。
getInstance() 的性能对应用程序很关键。
*/

namespace SingletonPattern
{
    public class Singleton4
    {
        private volatile static Singleton4 singleton;
        private static readonly object singletonLock = new object();

        private Singleton4() { }
        public static Singleton4 getSingleton()
        {
            if (singleton == null)
            {
                // When the first thread runs here, it will "lock" the locker object at this time,
                // When the second thread runs this method, it first detects that the locker object is in the "locked" state,
                // The thread will be suspended waiting for the first thread to unlock
                // After the first thread runs, the object will be "unlocked"
                lock (singletonLock)
                {
                    if (singleton == null)
                    {
                        singleton = new Singleton4();
                    }
                }
            }
            return singleton;
        }
    }
}
