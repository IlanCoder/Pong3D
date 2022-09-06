using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Warcos was heeee - heeee

public class GameManager : MonoBehaviour
{
    public List<Player> Players = new List<Player>();
    public Ball GameBall;

    public static GameManager Instance; //Singleton

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
