using TaskMaster;

namespace TaskMaster
{
    partial class Program
    {
        static readonly FileActions<Task> fileActions = new("./06-TaskMaster/tasks.json");
        static readonly List<Task> tasks = fileActions.ReadFile();
        static readonly Queries queries = new(tasks);
        public static void TaskMaster()
        {
            bool exit = false;
            while (!exit)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine("------Task Menu------");
                WriteLine("\n1. List tasks");
                WriteLine("2. Add task");
                WriteLine("3. Mark task as completed");
                WriteLine("4. Edit task");
                WriteLine("5. Delete task");
                WriteLine("6. View tasks by status");
                WriteLine("7. Search task by description");
                WriteLine("8. Exit");
                Write("\nSelect an option: ");

                switch (ReadLine())
                {
                    case "1":
                        queries.ListTasks();
                        break;
                    case "2":
                        queries.AddTask();
                        break;
                    case "3":
                        queries.MarkTaskAsCompleted();
                        break;
                    case "4":
                        queries.EditTask();
                        break;
                    case "5":
                        queries.RemoveTask();
                        break;
                    case "6":
                        queries.TasksByState();
                        break;
                    case "7":
                        queries.TasksByDescription();
                        break;
                    case "8":
                        exit = true;
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}

