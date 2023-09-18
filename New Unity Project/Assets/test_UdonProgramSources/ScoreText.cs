
using UdonSharp;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ScoreText : UdonSharpBehaviour
{
    private Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }
    public void UpdateScoreText(int newScore)
    {
        scoreText.text = "SCORE: " + newScore.ToString();
    }
}

