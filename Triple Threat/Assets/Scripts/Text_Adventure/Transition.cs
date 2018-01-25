using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition
{

    // Use this for initialization
    private State from;
    private string[] inputs;
    private string[] outputs;
    private State to;

    public Transition(State from, string[] inputs, string[] outputs, State to)
    {
        this.from = from;
        this.inputs = inputs;
        this.outputs = outputs;
        this.to = to;
    }
}
