using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BestTime : MonoBehaviour
{
    
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MiliDisplay;
    
    void OnTriggerEnter()
    {
        MinuteDisplay.GetComponent<Text>().color = Color.yellow;
        SecondDisplay.GetComponent<Text>().color = Color.yellow;
        MiliDisplay.GetComponent<Text>().color = Color.yellow;

        if (LapTime.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTime.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTime.SecondCount + ".";
        }

        if(LapTime.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" +LapTime.MinuteCount + ":";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTime.MinuteCount + ":";
        }
        MiliDisplay.GetComponent<Text>().text = "" + LapTime.MiliDisplay;

        LapTime.MinuteCount = 0;
        LapTime.SecondCount = 0;
        LapTime.MiliCount = 0;

        StartCoroutine(StopGame());

    }
    IEnumerator StopGame()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
