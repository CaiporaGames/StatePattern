using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateState : MonoBehaviour, IState
{
    PlayerController playerController;

    public void Handle(PlayerController playerController)//Is inside the Update!
    {
        if (!this.playerController)
        {
            this.playerController = playerController;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            playerController.StopState();
        }

        transform.Rotate(Vector3.one * Time.deltaTime * 20);
    }
}
