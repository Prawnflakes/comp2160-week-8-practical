using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class Scorekeeper : MonoBehaviour
{
    // Singleton
    static private Scorekeeper instance;
    static public Scorekeeper Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("There is no Scorekeeper instance in the scene.");
            }
            return instance;
        }
    }
    public int[] Score
    {
        get
        {
            return score;
        }
    }

    public int pointsPerPickup = 1;
    private int[] score = { 0, 0 };

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        score[0] = 0;
        score[1] = 0;
    }

    public void IncrementScore(GameObject player)
    {
        if(player.name == "Player1")
        {
            score[0] += pointsPerPickup;
            Debug.Log(player.name + " +1 cpoin, curr score = " + score[0]);
        }
        if(player.name == "Player2")
        {
            score[1] += pointsPerPickup;
            Debug.Log(player.name + " +1 cpoin, curr score = " + score[1]);
        }
    }
}
