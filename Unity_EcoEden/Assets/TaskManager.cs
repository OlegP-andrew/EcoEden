using UnityEngine;
using System.Collections.Generic;

public class TaskManager : MonoBehaviour
{
    public GameObject taskItemPrefab;
    public Transform taskPanel;

    private List<Task> tasks = new List<Task>();

    private void Start()
    {
        AddTask("Move around to explore the surrounding");
        AddTask("Explore the alien flora and report back to the astronaut");
        AddTask("Learn 3 types of plants");
    }

    public void AddTask(string taskName)
    {
        Task task = new Task(taskName);
        tasks.Add(task);
        GameObject newTaskItem = Instantiate(taskItemPrefab, taskPanel);
        newTaskItem.GetComponent<TaskItem>().SetText(taskName);
    }

    public void RemoveTask(string taskName)
    {
        Task taskToRemove = tasks.Find(task => task.Name == taskName);
        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
        }

        foreach (Transform child in taskPanel)
        {
            if (child.GetComponent<TaskItem>().GetText() == taskName)
            {
                Destroy(child.gameObject);
                break;
            }
        }
    }
}

public class Task
{
    public string Name { get; private set; }
    public Task(string name)
    {
        Name = name;
    }
}
