using UnityEngine;
using TMPro;

public class TaskItem : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    public void SetText(string text)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = text;
        }
    }

    public string GetText()
    {
        return textMeshPro != null ? textMeshPro.text : "";
    }
}
