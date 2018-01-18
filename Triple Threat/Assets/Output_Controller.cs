using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Output_Controller : MonoBehaviour
{

    private List<string> history;
    private Text outputText;

    // Use this for initialization
    void Start()
    {
        this.history = new List<string>();
        this.outputText = gameObject.GetComponent(typeof(Text)) as Text;

    }

    // Update is called once per frame
    void Update()
    {
        this.outputText.text = historyToText();
    }

    public void receiveMessage(string message)
    {
        Debug.Log("[Output_Controller] - Receiving Output: " + message);
        this.history.Add(message);
    }

    string historyToText()
    {
        return string.Join(string.Empty, this.history.ToArray());
    }
}
