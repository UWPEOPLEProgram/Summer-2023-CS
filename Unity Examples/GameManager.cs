using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//6
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private static int points = 0;

    //6
    public Text pointsText;

    public static void AddPoints(int number)
    {
        points += number;
    }

    public static int GetPoints()
    {
        return points;
    }

    void Update()
    {
        pointsText.text = "Points: " + points.ToString();
    }

}
