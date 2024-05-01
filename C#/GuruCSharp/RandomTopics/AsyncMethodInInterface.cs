using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.RandomTopics
{
    interface IAsyncMethod
    {
        Task<int> LongRunningAsyncMethodReturnInteger();

        void LongRunningAsyncReturnsVoid();
    }
    
    // We can not declare async in interface and there is no impact of async while overrriding.
    // if we awant to declare Async methods in interface we need to set return type as Task or Task<T>.

    class AsyncMethodInInterface : IAsyncMethod
    {
       public async Task<int> LongRunningAsyncMethodReturnInteger() 
        {
            Task<int> task = new Task<int>(() => { return 5; });
            task.Start();
            return await task;
        }

        public async void LongRunningAsyncReturnsVoid()
        {
           await Task.Factory.StartNew(() =>
            {
                Task.Delay(1000);
                Console.WriteLine("Method returning Void");
            });
            
        }
    }
}
