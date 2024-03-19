using UnityEngine;
using System.Collections.Generic;

public class TaskManager : MonoBehaviour
{
    public GameObject taskItemPrefab;
    public Transform taskPanel;

    private List<Task> tasks = new List<Task>();
    private List<GameObject> instantiatedTaskItems = new List<GameObject>();
    [SerializeField] float verticalSpacing = 75f;

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
        instantiatedTaskItems.Add(newTaskItem);
        AdjustTaskPosition(newTaskItem.transform, instantiatedTaskItems.Count);
    }

    public void RemoveTask(string taskName)
    {
        Task taskToRemove = tasks.Find(task => task.Name == taskName);
        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
        }

        GameObject taskItemToRemove = instantiatedTaskItems.Find(item => item.GetComponent<TaskItem>().GetText() == taskName);
        if (taskItemToRemove != null)
        {
            instantiatedTaskItems.Remove(taskItemToRemove);
            Destroy(taskItemToRemove);
        }

        for (int i = 0; i < instantiatedTaskItems.Count; i++)
        {
            AdjustTaskPosition(instantiatedTaskItems[i].transform, i);
        }
    }

    private void AdjustTaskPosition(Transform taskTransform, int index)
    {
        float posY = taskTransform.localPosition.y - (index * (verticalSpacing + taskTransform.GetComponent<RectTransform>().rect.height));
        taskTransform.localPosition = new Vector3(taskTransform.localPosition.x, posY, taskTransform.localPosition.z);
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

