using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.CustomThreadPool
{
    internal class CustomThreadPool
    {
        BlockingCollection<Action> _taskQueue;
        List<Thread> _workers;
        volatile Boolean _isShutdown;
        public CustomThreadPool(int poolSize)
        {
            _taskQueue = new BlockingCollection<Action>();
            _workers = new List<Thread>(poolSize);
            for(int i = 0; i < poolSize; i++)
            {
                Thread worker = new Thread(() => {
                    foreach (Action task in _taskQueue.GetConsumingEnumerable())
                    {
                        task();
                    }
                });
                worker.Name = $"Worker-{i}";
                _workers.Add(worker);
                worker.Start();
            }
        }
        public void Submit(Action task)
        {
            _taskQueue.Add(task);
        }
        public void Shutdown()
        {
            _taskQueue.CompleteAdding();
            foreach(Thread worker in _workers)
            {
                worker.Join();
            }
        }
    }
}
