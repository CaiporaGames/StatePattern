using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopState : MonoBehaviour, IState
{

    PlayerController playerController;


    public void Handle(PlayerController playerController)//Is inside the Update!
    {
        if (!this.playerController)
        {
            this.playerController = playerController;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            playerController.ScaleState();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            playerController.RotateState();
        }
    }   
}
