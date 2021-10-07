using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Singleton
    static private UIManager instance;
    static public UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("There is not UIManager in the scene.");
            }
            return instance;
        }
    }

    public Text scoreTextP1;
    public Text scoreTextP2;
    public string scoreFormatP1 = "Player 1 Score: {0}";
    public string scoreFormatP2 = "Player 2 Score: {0}";

    void Awake()
    {
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
    }

    void Update()
    {
        scoreTextP1.text = string.Format(scoreFormatP1, Scorekeeper.Instance.Score[0]);
        scoreTextP2.text = string.Format(scoreFormatP2, Scorekeeper.Instance.Score[1]);
    }
}
