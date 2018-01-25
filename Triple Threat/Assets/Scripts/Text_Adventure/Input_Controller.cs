using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Input_Controller : MonoBehaviour
{

    private InputField mainInput;
    public Output_Controller outputController;
    public int charLimit = 500;
    public InputField.CharacterValidation charValidation = InputField.CharacterValidation.EmailAddress;
    public InputField.ContentType contentType = InputField.ContentType.Custom;

    // Use this for initialization
    void Start()
    {
        if (outputController == null)
        {
            outputController = GameObject.Find("Output").GetComponent(typeof(Output_Controller)) as Output_Controller;
        }
        this.mainInput = gameObject.GetComponent(typeof(InputField)) as InputField;
        this.mainInput.characterLimit = this.charLimit;
        this.mainInput.characterValidation = this.charValidation;
        this.mainInput.contentType = this.contentType;
        this.mainInput.onEndEdit.AddListener(delegate { SubmitInput(this.mainInput); });
        this.mainInput.onValidateInput += delegate (string input, int charIndex, char addedChar) { return ValidateInput(addedChar); };
    }

    char ValidateInput(char addedChar)
    {
        // Placeholder function for validating.
        return addedChar;
    }

    void SubmitInput(InputField input)
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Sending Message: " + input.text);
            outputController.receiveMessage(input.text);
            EventSystem.current.SetSelectedGameObject(input.gameObject, null);
            input.OnPointerClick(new PointerEventData(EventSystem.current));

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
