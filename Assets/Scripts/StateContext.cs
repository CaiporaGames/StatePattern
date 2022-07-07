using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateContext
{
    PlayerController playerController;

    public IState CurrentState { get; set; }


    public StateContext(PlayerController playerController)
    {
        this.playerController = playerController;
    }

    public void Transition()
    {
        CurrentState.Handle(playerController);
    }

    public void Transition(IState state)
    {
        CurrentState = state;
        CurrentState.Handle(playerController);
    }
}
