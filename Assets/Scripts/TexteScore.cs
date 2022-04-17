using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TexteScore : MonoBehaviour
{
    private Text texteScore;
    private GameObject scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        texteScore = GetComponent<Text>();
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        texteScore.text = "Score: " + scoreManager.GetComponent<ScoreManager>().score.ToString();
    }
}
