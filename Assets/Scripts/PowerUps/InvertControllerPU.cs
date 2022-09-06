using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Warcos was heeee - heeee

public class InvertControllerPU : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Ball") return;
        foreach(Player player in GameManager.Instance.Players)
        {
            player.InvertControls();
        }        
    }
}
