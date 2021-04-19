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

            Action action = () =>
                                {
                                   for(int x=0;x<=300;x++)
                                   {
                                       Task.Delay(50);
                                       Console.WriteLine(x);

                                   }
                                   
                                };
            // Create a task and supply a user delegate by using a lambda expression.
            Task taskA = new Task( () => Console.WriteLine("Hello from taskA."));
            Task taskB= new Task(action);
            taskB.Start();
            
            
            taskA.Start();
            
            // Start the task.

            await Task.WhenAny(taskA,taskB);
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
