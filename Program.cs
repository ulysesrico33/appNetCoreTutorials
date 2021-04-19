using System;
using System.Threading;
using System.Threading.Tasks;

namespace appNetCoreTutorials
{
    class Program
    {
        public static void Main()
        {

           Thread.CurrentThread.Name = "Main";

            // Create a task and supply a user delegate by using a lambda expression.
            Task taskA = new Task( () => Console.WriteLine("Hello from taskA."));
            Task taskB= new Task(()=>Console.WriteLine("Hello from taskB."));
            // Start the task.
            taskA.Start();
            taskB.Start();

            // Output a message from the calling thread.
            
            Console.WriteLine(taskA.Status);
        }

        Action task1=>(Console.WriteLine('Hello'));
    }
}
