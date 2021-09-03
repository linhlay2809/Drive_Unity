using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public AudioClip audio1;
    public Text MyScore;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        MyScore.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score += 1;
            MyScore.text = "Score: " + score;
            other.gameObject.SetActive(false);
            this.GetComponent<AudioSource>().PlayOneShot(this.audio1);   
        }
        
    }

}
