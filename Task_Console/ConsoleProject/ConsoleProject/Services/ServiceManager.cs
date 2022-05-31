using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Services
{
    class ServiceManager<TItem> 
    {
       public Queue<TItem> Items = new Queue<TItem>();
        public bool done;

        public void addInQueue(TItem Item)
        {
            if (done)
            {
                Items.Enqueue(Item);
            }
        }

        public  Queue<TItem> VipPop(TItem item)
        {
            if (done)
            {
            Items.Enqueue(item);
            }
            return Items;
        }

        public async void addInQueueAsync(TItem item1, TItem item2)
        {
            if (done)
            {
                Items.Enqueue(item1);
                Items.Enqueue(item2);
            }
        }

        public string removeFromQueue()
        {
            if (done)
            {
                TItem item = Items.Dequeue();

                return item.ToString();
            }
            return "null";
        }

        public bool IsQueueEmpty()
        {
            return Items.Count < 1;
        }





    }
}
