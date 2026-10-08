using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.ProducerConsumerProblem
{
    internal class ProducerConsumerProblem
    {
        BlockingCollection<Action> _taskQueue;
        int _capacity = 0;
        public ProducerConsumerProblem(int size)
        {
            _taskQueue= new BlockingCollection<Action>();
            _capacity = size;
        }
        void produce(Action task)
        {
            if (_taskQueue.Count == _capacity)
            {

            }
            _taskQueue.Add(task);
        }
    }
}
