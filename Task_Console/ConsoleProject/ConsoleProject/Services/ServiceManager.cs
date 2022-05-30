using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Services
{
    class ServiceManager<TItem> 
    {
        Stack<TItem> Items = new Stack<TItem>();
        public bool done;

        public void addInQueue(TItem Item)
        {
            if (done)
            {
                Items.Push(Item);
            }
        }

        public async void addInQueueAsync(TItem item1, TItem item2)
        {
            if (done)
            {
                Items.Push(item1);
                Items.Push(item2);
            }
        }

        public string removeFromQueue()
        {
            if (done)
            {
                TItem item = Items.Pop();

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
