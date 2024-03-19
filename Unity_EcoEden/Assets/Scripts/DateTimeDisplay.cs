using UnityEngine;
using TMPro;
using System;

public class DateTimeDisplay : MonoBehaviour
{
    [SerializeField] private float timeRate = 1.0f; // Serialized field to control time rate
    [SerializeField] private TextMeshProUGUI textMeshPro; // Reference to the TextMeshPro component
    private DateTime customStartTime = new DateTime(3011, 11, 11, 0, 0, 0);
    private DateTime trueStartTime = DateTime.Now;

    private void Update()
    {
        DateTime adjustedTime = customStartTime.AddSeconds(Time.realtimeSinceStartup * timeRate);
        string formattedTime = adjustedTime.ToString("yyyy-MM-dd HH:mm");

        if (textMeshPro != null)
        {
            textMeshPro.text = formattedTime;
        }
    }
}
