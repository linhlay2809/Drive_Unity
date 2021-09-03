using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioClip audioClick;

    public Animator transition;
    public float transitionTime = 1f;

    private void Start()
    {
        
    }
    // Dung de chuyen scene vao playgame
    public void PlayGame()
    {
        StartCoroutine(NextMenu(SceneManager.GetActiveScene().buildIndex + 1));
        this.GetComponent<AudioSource>().Stop();
        this.GetComponent<AudioSource>().PlayOneShot(this.audioClick);
    }
    public void PlayGame2()
    {
        StartCoroutine(NextMenu(SceneManager.GetActiveScene().buildIndex + 2));
        this.GetComponent<AudioSource>().Stop();
        this.GetComponent<AudioSource>().PlayOneShot(this.audioClick);
    }
    public IEnumerator NextMenu(int levelIndex)
    {
        transition.SetBool("LoadMenu", true);
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
    
    // Dung de thoat khoi game
    public void QuitGame()
    {
        StartCoroutine(QuitMenu());
        Debug.Log("QUIT!");
        this.GetComponent<AudioSource>().Stop();
        this.GetComponent<AudioSource>().PlayOneShot(this.audioClick);
        Application.Quit();
    }
    public IEnumerator QuitMenu()
    {
        transition.SetBool("LoadMenu", true);
        yield return new WaitForSeconds(transitionTime);

    }
    
    
}
