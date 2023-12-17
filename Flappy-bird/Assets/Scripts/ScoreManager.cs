using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; set; }
    [SerializeField] private TextMeshProUGUI scoreText;
    public int score { get; set; }
    private void Start()
    {
        Instance = this;
        SetScore(0);
    }
    public void SetScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
    }
}
