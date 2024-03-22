using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;
using UnityEngine.Events;
using TMPro;

public class ChatGPTManager : MonoBehaviour
{
    private OpenAIApi openAI = new OpenAIApi("");
    private List<ChatMessage> messages = new List<ChatMessage>();

    private string line;
    private bool respondToInput;
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        respondToInput = true;
        line = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (respondToInput && Input.GetKeyDown(KeyCode.Q))
        {
            if (line != txt.text)
            {
                StopCoroutine("PlayText");
                txt.text = line;
            }
            // else 
            // {
            //     txt.text = "";
            //     AskChatGPT("Say something evil in 20 words");
            // }
        }
    }

    public async void AskChatGPT(string newText, TextMeshProUGUI text)
    {
        txt = text; 

        respondToInput = false;
        ChatMessage newMessage = new ChatMessage();
        newMessage.Content = newText;
        newMessage.Role = "user";

        messages.Add(newMessage);

        CreateChatCompletionRequest request = new CreateChatCompletionRequest();
        request.Messages = messages;
        request.Model = "gpt-3.5-turbo";

        var response = await openAI.CreateChatCompletion(request);

        if (response.Choices != null && response.Choices.Count > 0)
        {
            var chatResponse = response.Choices[0].Message;
            messages.Add(chatResponse);

            respondToInput = true;

            // onResponse.Invoke(chatResponse.Content);
            line = "";
            line = chatResponse.Content;

            // Delete later
            if (newText == "who are you") line = "I'm an astronaut. And by the way you look I assume you are a plant robot?";

            StartCoroutine("PlayText");
        }
    }

    IEnumerator PlayText()
	{
		foreach (char c in line) 
		{
			txt.text += c;
            if (c.ToString() != " ") yield return new WaitForSeconds(waitTime);
		}
	}
}
