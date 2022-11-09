using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timeTextScript : MonoBehaviour

{
    public static timeTextScript instanceS;
    public float TimeLeft;
    public bool TimerOn = false;

    public Text TimerTxt;

    private void Awake()
    {
        instanceS = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("End Time");
                TimeLeft = 0;
                TimerOn = false;
                SceneManager.LoadScene("gameOver");
            }
        }

    }


    void updateTimer(float currentTime)

    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

}