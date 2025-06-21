using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterMediateConcepts
{
    internal class InterMediateConcepts1
    {
        public class ResourceBox<T>
        {
            private T _item;

            public ResourceBox(T item)
            {
                _item = item;
            }

            public T GetItem()
            {
                return _item;
            }
        }
        public class DemoFeatures
        {
            private static List<string> students = new List<string> { "Ali", "Sara", "Ahmed" };
            private static Dictionary<string, string> subjectTeachers = new Dictionary<string, string> { { "Math", "Mr. Khalid" }, { "Science", "Ms. Ayesha" } };
            private static HashSet<string> clubs = new HashSet<string> { "Chess", "Drama", "Science" };
            private static Queue<string> printQueue = new Queue<string>(new[] { "ID_Card.pdf", "Timetable.docx" });
            private static Stack<string> pages = new Stack<string>(new[] { "Dashboard", "Students", "Edit Student" });

            public static void _1st_Part()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("--- COLLECTIONS AND GENERICS MENU ---\n");
                    Console.WriteLine("1. View/Add Students");
                    Console.WriteLine("2. View/Add Subjects and Teachers");
                    Console.WriteLine("3. View/Add Clubs");
                    Console.WriteLine("4. View/Add Print Queue");
                    Console.WriteLine("5. View Page Stack");
                    Console.WriteLine("6. Back to Main Menu");
                    Console.Write("Choose an option: ");

                    string choice = Console.ReadLine();
                    Console.Clear();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Current Students:");
                            foreach (var s in students) Console.WriteLine("- " + s);
                            Console.Write("Add a new student (or leave blank): ");
                            string newStudent = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newStudent)) students.Add(newStudent);
                            break;
                        case "2":
                            Console.WriteLine("Subject Teachers:");
                            foreach (var pair in subjectTeachers)
                                Console.WriteLine($"{pair.Key} is taught by {pair.Value}");
                            Console.Write("Add Subject (or leave blank): ");
                            string subject = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(subject))
                            {
                                Console.Write("Enter Teacher's Name: ");
                                string teacher = Console.ReadLine();
                                subjectTeachers[subject] = teacher;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Available Clubs:");
                            foreach (var c in clubs) Console.WriteLine("- " + c);
                            Console.Write("Suggest a club (or leave blank): ");
                            string club = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(club))
                            {
                                if (clubs.Add(club)) Console.WriteLine("Club added.");
                                else Console.WriteLine("Already exists.");
                            }
                            break;
                        case "4":
                            Console.WriteLine("Current Print Queue:");
                            foreach (var q in printQueue) Console.WriteLine("- " + q);
                            Console.Write("Add file to print (or leave blank): ");
                            string file = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(file)) printQueue.Enqueue(file);
                            if (printQueue.Count > 0)
                            {
                                Console.WriteLine("Printing: " + printQueue.Dequeue());
                            }
                            break;
                        case "5":
                            Console.WriteLine("Current Page Stack:");
                            foreach (var p in pages) Console.WriteLine("- " + p);
                            if (pages.Count > 0)
                            {
                                Console.WriteLine("Going back from: " + pages.Pop());
                                Console.WriteLine("Now on: " + (pages.Count > 0 ? pages.Peek() : "Home"));
                            }
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                    Console.WriteLine("\nPress Any Key To Continue...");
                    Console.ReadKey();
                }
            }

        }
    }
}
