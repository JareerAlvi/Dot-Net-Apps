using System;
using System.Threading;

namespace InterMediateConcepts
{
    internal class InterMediateConcepts2
    {
        public class TaskProgressEventArgs : EventArgs
        {
            public int Percentage { get; set; }
            public TaskProgressEventArgs(int percent) => Percentage = percent;
        }


        public class TaskRunner
        {
            public event EventHandler<TaskProgressEventArgs> ProgressUpdated;

            public void RunTask()
            {
                for (int i = 0; i <= 100; i += 25)
                {
                    Thread.Sleep(300); // simulate work
                    OnProgressUpdated(new TaskProgressEventArgs(i));
                }
            }

            protected virtual void OnProgressUpdated(TaskProgressEventArgs e)
            {
                ProgressUpdated?.Invoke(this, e);
            }
        }

        public class Logger
        {
            public void LogProgress(object sender, TaskProgressEventArgs e)
            {
                Console.WriteLine($"Logger: Task is {e.Percentage}% complete.");
            }
        }


        public static void _2nd_Part()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- DELEGATES AND EVENTS MENU ---\n");
                Console.WriteLine("1. Print Message Using Delegate");
                Console.WriteLine("2. Run Task with Progress Updates");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter a message: ");
                        string msg = Console.ReadLine();
                        Action<string> simplePrinter = (m) => Console.WriteLine($"Delegate says: {m}");
                        simplePrinter(msg);
                        break;
                    case "2":
                        TaskRunner runner = new TaskRunner();
                        Logger logger = new Logger();
                        runner.ProgressUpdated += logger.LogProgress;
                        runner.ProgressUpdated += (s, e) =>
                        {
                            Console.WriteLine($"[Lambda] Progress: {e.Percentage}%");
                        };
                        Console.WriteLine("\nRunning Task...");
                        runner.RunTask();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine("\nPress Any Key To Continue...");
                Console.ReadKey();
            }
        }
    }
}
