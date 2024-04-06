﻿namespace Paxos
{
    abstract class ThreadHost
    {
        Thread hostThread;
        
        public void start()
        {
            ThreadStart runProcedure = new ThreadStart(Run);
            this.hostThread = new Thread(runProcedure);
            this.hostThread.Start();
        }

        public virtual void Run()
        {

        }

        public void yield()
        {

            Thread.Sleep(10);
        }

    }
}
