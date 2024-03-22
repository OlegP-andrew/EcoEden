using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeechBubble : MonoBehaviour
{
    public Transform cam;
    public ChatGPTManager chatGPTManager;
    private List<Line> lines = new List<Line>();
    public TextMeshProUGUI txt;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        AddLine("I should explore this place!");
        AddLine("Press tab to open up my robot menu");
        AddLine("I love it when it rains!");

        StartCoroutine(ShowLineRepeatedly());
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cam);
    }

    public void AddLine(string lineInput)
    {
        Line line = new Line(lineInput);
        lines.Add(line);
    }

    void ShowLine()
    {
        txt.text = lines[0].Content;
    }

    public void RemoveLine()
    {
        if (lines.Count != 0)
        {
            lines.RemoveAt(0);
        }
    }

    IEnumerator ShowLineRepeatedly()
    {
        while (true)
        {
            panel.SetActive(true);
            ShowLine();
            yield return new WaitForSeconds(4);
            txt.text = "";
            RemoveLine();
            panel.SetActive(false);
            yield return new WaitForSeconds(5);
        }
    }
}

public class Line
{
    public string Content { get; private set; }

    public Line(string content)
    {
        Content = content;
    }
}