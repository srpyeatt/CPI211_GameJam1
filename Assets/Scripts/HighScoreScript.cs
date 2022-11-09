using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HighScoreScript : MonoBehaviour
{


    public float highscore = 0;
    public Text highscoreText;
    // Start is called before the first frame update
    void Update()
    {
        if (highscoreText.name == "highscoreText")
        {
            highscoreText.text = "Highscore: " + highscore;
        }


    }

    public void AddHighScore()
    {
        highscore++;
        Debug.Log("highscore added");
    }
}