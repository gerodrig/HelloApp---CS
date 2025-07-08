using System.Data;
using BetterConsoles.Tables;
using BetterConsoles.Tables.Configuration;
using TaskMaster;

namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
    private readonly List<Task> Tasks = _tasks;

    public void ListTasks()
    {
      Utils.CustomWrite("-----List of Tasks-----", Utils.MessageType.Info);
      Table table = new("ID", "Description", "State");

      Tasks.ForEach(t => table.AddRow(t.Id, t.Description, t.Completed ? "Completed" : ""));
      table.Config = TableConfig.Unicode();

      Write(table.ToString());
      ReadKey();
    }

    public List<Task> AddTask()
    {
      try
      {
        Clear();
        Utils.CustomWrite("---Add Task--", Utils.MessageType.Info);
        Utils.CustomWrite("Add task description:", Utils.MessageType.Info);

        string description = ReadLine()!;
        Task newTask = new(Utils.GeneratedId(), description);
        Tasks.Add(newTask);
        Utils.CustomWrite("Task added successfully!", Utils.MessageType.Success);

        return Tasks;
      }
      catch (Exception ex)
      {

        Utils.CustomWrite($"An error happened when adding the task: {ex.Message}", Utils.MessageType.Error);
        return Tasks;
      }
    }

    public List<Task> MarkTaskAsCompleted()
    {

      try
      {
        Utils.CustomWrite("---Set Task as Completed---", Utils.MessageType.Info);
        Utils.CustomWrite("---Enter the ID of the task to be marked as completed---", Utils.MessageType.Info);

        string id = ReadLine()!;
        Task task = Tasks.Find(t => t.Id == id)!;

        if (task == null)
        {
          Utils.CustomWrite($"the task with ID {{ {id} }} was not found", Utils.MessageType.Warning);
          return Tasks;
        }

        task.Completed = true;
        task.ModifiedAt = DateTime.Now;

        Utils.CustomWrite("Task marked as Completed successfully!", Utils.MessageType.Success);

        return Tasks;

      }
      catch (Exception ex)
      {

        Utils.CustomWrite($"An error happened when marking the task: {ex.Message}", Utils.MessageType.Error);
        return Tasks;
      }
    }
    public List<Task> EditTask()
    {

      try
      {
        Utils.CustomWrite("---Edit Task---", Utils.MessageType.Info);
        Utils.CustomWrite("---Enter the ID of the task to be edited---", Utils.MessageType.Info);

        string id = ReadLine()!;
        Task task = Tasks.Find(t => t.Id == id)!;

        if (task == null)
        {
          Utils.CustomWrite($"the task with ID {{ {id} }} was not found", Utils.MessageType.Warning);
          return Tasks;
        }

        Utils.CustomWrite("---Enter the new task description---", Utils.MessageType.Info);
        string description = ReadLine()!;
        task.Description = description;
        task.ModifiedAt = DateTime.Now;

        Utils.CustomWrite("Task marked edited successfully!", Utils.MessageType.Success);

        return Tasks;

      }
      catch (Exception ex)
      {

        Utils.CustomWrite($"An error happened when editing the task: {ex.Message}", Utils.MessageType.Error);
        return Tasks;
      }
    }
    public List<Task> RemoveTask()
    {

      try
      {
        Utils.CustomWrite("---Remove Task---", Utils.MessageType.Info);
        Utils.CustomWrite("---Enter the ID of the task to be removed---", Utils.MessageType.Info);

        string id = ReadLine()!;
        Task task = Tasks.Find(t => t.Id == id)!;

        if (task == null)
        {
          Utils.CustomWrite($"the task with ID {{ {id} }} was not found", Utils.MessageType.Warning);
          return Tasks;
        }

        Utils.CustomWrite($"Are you sure that you want to remove task {{{id}}} - {task.Description}?", Utils.MessageType.Error);
        Utils.CustomWrite($"Type 'y' to confirm or any other key to cancel and return to main Menu.", Utils.MessageType.Warning);

        string confirmation = ReadLine()!;

        if (!confirmation.Equals("y", StringComparison.CurrentCultureIgnoreCase))
        {
          return Tasks;
        }


        Tasks.Remove(task);

        Utils.CustomWrite("Task has been deleted!", Utils.MessageType.Success);

        return Tasks;

      }
      catch (Exception ex)
      {

        Utils.CustomWrite($"An error happened when deleting the task: {ex.Message}", Utils.MessageType.Error);
        return Tasks;
      }
    }
    public void TasksByState()
    {
      Clear();
      try
      {
        Utils.CustomWrite("---Tasks By State---", Utils.MessageType.Info);
        Utils.CustomWrite("1. Completed", Utils.MessageType.Success);
        Utils.CustomWrite("2. Pending", Utils.MessageType.Warning);
        Utils.CustomWrite("Select the option to show Tasks By State", Utils.MessageType.Info);

        string taskState = ReadLine()!;

        if (taskState != "1" && taskState != "2")
        {
          Utils.CustomWrite("Invalid Option", Utils.MessageType.Warning);
          return;
        }

        bool completed = taskState == "1";
        List<Task> filteredTasks = [.. Tasks.Where(t => t.Completed == completed)];

        if (filteredTasks.Count == 0)
        {
          Utils.CustomWrite($"Tasks with the selected state were not found", Utils.MessageType.Warning);
          return;
        }

        Table table = new("ID", "Description", "State");
        filteredTasks.ForEach(t => table.AddRow(t.Id, t.Description, t.Completed ? "Completed" : ""));
        table.Config = TableConfig.Unicode();

        Write(table.ToString());
        ReadKey();

      }
      catch (Exception ex)
      {

        Utils.CustomWrite($"An error happened when searching for the task: {ex.Message}", Utils.MessageType.Error);
        return;
      }
    }
    public void TasksByDescription()
    {
      Clear();
      try
      {
        Utils.CustomWrite("---Tasks By Description---", Utils.MessageType.Info);
        Utils.CustomWrite("Enter the description for the tasks to find", Utils.MessageType.Info);

        string description = ReadLine()!;
        List<Task> matchingTasks = Tasks.FindAll(t => t.Description?.Contains(description, StringComparison.OrdinalIgnoreCase) ?? false);

        if (matchingTasks.Count == 0)
        {
          Utils.CustomWrite($"Tasks with the selected description were not found", Utils.MessageType.Warning);
          return;
        }

        Table table = new("ID", "Description", "State");
        matchingTasks.ForEach(t => table.AddRow(t.Id, t.Description, t.Completed ? "Completed" : ""));
        table.Config = TableConfig.Unicode();

        Write(table.ToString());
        ReadKey();

      }
      catch (Exception ex)
      {

        Utils.CustomWrite($"An error happened when searching for the task by description: {ex.Message}", Utils.MessageType.Error);
        return;
      }
    }
  }
}



