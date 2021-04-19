using System;
using System.Threading;
using System.Threading.Tasks;

namespace appNetCoreTutorials
{
    class Program
    {
        public static async Task Main()
        {

           Thread.CurrentThread.Name = "Main";

            // Create a task and supply a user delegate by using a lambda expression.
            Task taskA = new Task( () => Console.WriteLine("Hello from taskA."));
            Task taskB= new Task(()=>Console.WriteLine("Hello from taskB."));
            // Start the task.

            await Task.WhenAll(taskA,taskB);
            Console.WriteLine("All done");
            
            
        }

      
    }

    class Program1
    {
        public static void Main()
        {
            Console.WriteLine("I am Program 1");

        }


    }
}
