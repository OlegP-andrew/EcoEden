using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeechBubble : MonoBehaviour
{
    public Transform cam;
    public ChatGPTManager chatGPTManager;
    public List<Line> lines = new List<Line>();
    public TextMeshProUGUI txt;
    public GameObject panel;
    public float sphereRadius;
    public List<LayerMask> layerMasks;

    // Start is called before the first frame update
    void Start()
    {
        AddLine("Where am I? I should look around.");
        AddLine("Press TAB to open up my robot menu");
        // AddLine("I love it when it rains!");

        StartCoroutine(ShowLineRepeatedly());
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cam);

        AddLineWhenAppropriate();
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

    private void AddLineWhenAppropriate()
    {
        foreach (LayerMask layerMask in layerMasks)
        {
            bool inRange = Physics.CheckSphere(transform.position, sphereRadius, layerMask);
            if (inRange)
            {
                layerMasks.Remove(layerMask);
                
                if (layerMask == LayerMask.GetMask("Seed")) 
                {
                    AddLine("I should try pushing the seed!");
                }
                // TODO: follow the same structure
                if (layerMask == LayerMask.GetMask("Fog"))
                {
                    AddLine("Astro told me to stay away from fog...");
                    AddLine("The rain makes the air fresh");
                }
                if (layerMask == LayerMask.GetMask("Big Bamboo"))
                {
                    AddLine("How to get to the top of the cliff?");
                }
                if (layerMask == LayerMask.GetMask("Crystal"))
                {
                    AddLine("There's some light trapped in the crystal.");
                }
                if (layerMask == LayerMask.GetMask("Boat"))
                {
                    AddLine("That leaf looks like a boat!");
                    AddLine("Row, row, row your boat");
                    AddLine("Gently down the stream");
                }
                if (layerMask == LayerMask.GetMask("Crystalwall"))
                {
                    AddLine("I wonder what's behind this wall");
                }
                if (layerMask == LayerMask.GetMask("Buttonmush"))
                {
                    Debug.Log("s");
                    AddLine("These little mushrooms look like buttons...");
                }
                if (layerMask == LayerMask.GetMask("Autgap"))
                {
                    AddLine("The gaps are soooo deep! I'm scared.");
                }
                if (layerMask == LayerMask.GetMask("Motherscene"))
                {
                    AddLine("I feel cold.");
                }
            }
        }
    }

    IEnumerator ShowLineRepeatedly()
    {
        while (true)
        {
            if (lines.Count != 0)
            {
                panel.SetActive(true);
                ShowLine();
                yield return new WaitForSeconds(4);

                txt.text = "";
                RemoveLine();
                panel.SetActive(false);
                yield return new WaitForSeconds(5);
            }
            else yield return null;
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