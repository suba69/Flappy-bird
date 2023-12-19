using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoseWindow : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreTXT;
    public Medal[] medals;
    public Image medalsDispaly;
    public void PlayerLose()
    {
        int score = ScoreManager.Instance.score;
        scoreText.text = score.ToString();

        int bestScore = PlayerPrefs.GetInt("BestScore");
        if (score > bestScore)
        {
            bestScore = score;
        }

        for (int i = 0; i < medals.Length; i++)
        {
            if (medals[i].ScoreNeed <= score)
            {              
                    medalsDispaly.gameObject.SetActive(true);
                    medalsDispaly.sprite = medals[i].MedalsSprite;     
             
            }
        }

        bestScoreTXT.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }
}
