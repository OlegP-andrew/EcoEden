using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextInterface : MonoBehaviour
{
    public GameObject outgoingBubblePrefab;
    public GameObject incomingBubblePrefab;
    public Transform dialoguePanel;
    public Transform scrollPanel;
    public TMP_InputField inputField;
    public TextMeshProUGUI txt;

    public ChatGPTManager chatGPTManager;

    private void Start()
    {
        inputField.onSubmit.AddListener(OnMessageSubmitted);
    }

    private void OnMessageSubmitted(string message)
    {
        CreateOutgoingBubble(message);
        CreateIncomingBubble();
        chatGPTManager.AskChatGPT(message, txt);
        inputField.text = "";
    }

    public void CreateOutgoingBubble(string message)
    {
        GameObject bubble = Instantiate(outgoingBubblePrefab, dialoguePanel);
        bubble.SetActive(true);
        bubble.GetComponentInChildren<TextMeshProUGUI>().text = message;
        ScrollToBottom();
    }

    public void CreateIncomingBubble()
    {
        GameObject bubble = Instantiate(incomingBubblePrefab, dialoguePanel);
        bubble.SetActive(true);
        txt = bubble.GetComponentInChildren<TextMeshProUGUI>();
        // bubble.GetComponentInChildren<TextMeshProUGUI>().text = message;
        ScrollToBottom();
    }

    private void ScrollToBottom()
    {
        Canvas.ForceUpdateCanvases();
        scrollPanel.GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
    }
}
