using System;
using System.Threading;
using System.Threading.Tasks;

namespace appNetCoreTutorials
{
    class Program
    {
        public static async Task Main()
        {

            // Create a task and supply a user delegate by using a lambda expression.
            Task taskA = new Task( () => Console.WriteLine("Hello from taskA."));
            taskA.Start();
            getCountOfNumber();
            
            Console.WriteLine("All done");
            
            
        }

        public static void getCountOfNumber()
        {

            Action action = () =>
                                {
                                   for(int x=0;x<=300;x++)
                                   {
                                       Task.Delay(50);
                                       Console.WriteLine(x);

                                   }
                                   
                                };

            Task task= new Task(action);   

            task.Start();                




        }

      
    }


}
