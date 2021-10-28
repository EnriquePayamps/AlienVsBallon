using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;
    public Text scoreText;
    int score = 0;
    float timer;

    private void Start()
    {
        scoreManager = this;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 10f)
        {
            timer = 0;
            score -= 5;
            scoreText.text = score + "";
            Debug.Log(score);
        }
    }


    public void RaiseScore(int s)
    {
        
        score += s;
        scoreText.text = score + "";
    }

    
}
