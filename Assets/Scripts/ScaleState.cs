using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleState : MonoBehaviour, IState
{
    PlayerController playerController;
    float scale = 100;

    public void Handle(PlayerController playerController)//Is inside the Update!
    {
        if (this.playerController)
        {
            this.playerController = playerController;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector3(1, 1, 1);
            playerController.StopState();
        }

        transform.localScale = new Vector3(Mathf.Sin(Time.deltaTime) * scale, Mathf.Sin(Time.deltaTime) * scale, Mathf.Sin(Time.deltaTime) * scale);
    }  
}
