using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    public AudioClip buttonClick;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        StateControlller.deaths = 0;
        playerAudio.PlayOneShot(buttonClick);
        if(SceneManager.GetActiveScene().name == "Outro"){
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene("Intro",LoadSceneMode.Single);
    }
    public void PlayCrashSound()
    {
        playerAudio.PlayOneShot(crashSound);
    }
}
