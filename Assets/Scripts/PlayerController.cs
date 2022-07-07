using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    StateContext stateContext;

    IState stopState, scaleState, rotateState;

    void Start()
    {
        stateContext = new StateContext(this);
        stopState = GetComponent<StopState>();
        scaleState = GetComponent<ScaleState>();
        rotateState = GetComponent<RotateState>();

        stateContext.Transition(rotateState);
    }

    void Update()
    {
        stateContext.Transition();       
    }

    public void StopState()
    {
        stateContext.Transition(stopState);

    }

    public void ScaleState()
    {
        stateContext.Transition(scaleState);

    }

    public void RotateState()
    {
        stateContext.Transition(rotateState);
    }

  
}
