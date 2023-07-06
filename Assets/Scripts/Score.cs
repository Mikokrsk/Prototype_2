using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score 
{
    public static int score = 0; 
    public static void PlusScore()
    {
        score++;
        Debug.Log($"Score = {score}");
    }
}
