
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AppleCollectionManager : UdonSharpBehaviour
{
    
    public int score = 0; //player score

    public ScoreText currentScore;

    private void Update()
    {
        if (currentScore != null)
        {
            currentScore.UpdateScoreText(score);
        }
    }

}
