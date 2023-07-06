using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Health 
{
    public static int health = 3;

    public static void GameOver()
    {
        if(health < 1)
        {
            Debug.Log("Game Over");
        }
        else
        {
            health--;
            Debug.Log($"Health = {health}");
        }      
    }
}
