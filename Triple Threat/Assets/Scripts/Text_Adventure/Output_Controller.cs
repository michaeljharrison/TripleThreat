using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Output_Controller : MonoBehaviour
{

    private List<string> history;
    private string response;
    private Text outputText;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        this.history = new List<string>();
        this.outputText = gameObject.GetComponent(typeof(Text)) as Text;
        this.animator = gameObject.GetComponent(typeof(Animator)) as Animator;

    }

    // Update is called once per frame
    void Update()
    {
        this.renderResponse();
    }

    void renderHistory()
    {
        this.outputText.text = string.Join("\n", this.history.ToArray());
    }

    void renderResponse()
    {
        this.outputText.text = this.response;

    }

    public void receiveMessage(string message)
    {
        Debug.Log("[Output_Controller] - Receiving Output: " + message);
        this.history.Add("User> " + message);
        this.response = "Resp> " + getResponse(message);
        this.history.Add("Resp> " + response);

    }

    string getResponse(string message)
    {
        // Global commands start with !
        if (message.StartsWith("!"))
        {
            return parseGlobalCommand(message);
        }
        else
        {
            return parseNormalCommand(message);
        }
    }

    string parseGlobalCommand(string message)
    {
        return "GLOBAL COMMAND";
    }

    string parseNormalCommand(string message)
    {
        return "NORMAL COMMAND";
    }
}
