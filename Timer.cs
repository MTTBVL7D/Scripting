using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public float seconds;
    public int minute;

    private void Update()
    {
        seconds -= Time.deltaTime;

        if(seconds == 0)
        {
            if(minute > 0)
            {
                seconds += 59;
                minute --;
            }
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
        int RoundSeconds = Mathf.RoundToInt(seconds);
        TimerText.text = minute + ":" + RoundSeconds;
    }


}

