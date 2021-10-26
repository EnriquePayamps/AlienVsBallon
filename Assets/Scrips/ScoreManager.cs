using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;
    int score = 0;

    private void Start()
    {
        scoreManager = this;
    }
    public void RaiseScore(int s)
    {
        score += s;
        Debug.Log(score);
    }
}
