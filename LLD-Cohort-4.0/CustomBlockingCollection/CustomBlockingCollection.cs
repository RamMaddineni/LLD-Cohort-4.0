using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.CustomBlockingCollection
{
    internal class CustomBlockingCollection<T>
    {
        private readonly Queue<T> _queue = new();
        private readonly object _gate = new();
        private readonly SemaphoreSlim _freeSlots;
        private readonly SemaphoreSlim _availableItems;

        public CustomBlockingCollection(int capacity)
        {
            if(capacity<=0) throw new ArgumentOutOfRangeException(nameof(capacity));

            
            _freeSlots= new SemaphoreSlim(capacity,capacity);// Signifies Intially full capacity of free slots.
            _availableItems=new SemaphoreSlim(0,capacity);// Signifies Intially No items.
        }
        public void Add(T item)
        {
            _freeSlots.Wait(); // Wait until there is a free slot.
            // now free slot is reserved. by decreasing freeslots count by 1
            try
            {
                lock (_gate) // to make enqueue/dequeue thread safe
                {
                    _queue.Enqueue(item);
                }
            }
            catch
            {
                _freeSlots.Release(); // release if enque fails.
                throw;
            }
            _availableItems.Release();
        }
        public T Take()
        {
            _availableItems.Wait(); // wait until there is an item.
            // now item is reserved to be taken.
            T item;
            try
            {
                lock (_gate) // to make enqueue/dequeue thread safe.
                {
                    item=_queue.Dequeue();
                }
            }
            catch
            {
                _availableItems.Release();
                throw;
            }
            _freeSlots.Release(); // if the item is successfully released then we can release one free slot.
            return item;
        }

    }
}
