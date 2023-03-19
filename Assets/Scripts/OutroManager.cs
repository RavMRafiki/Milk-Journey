using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class OutroManager : MonoBehaviour
{
    public GameObject background;
    public TextMeshProUGUI deathsText;
    private bool skip = false;
    private GameObject audioController;
    void Start()
    {
        Invoke("Daddy",2f);
        deathsText.text = "Deaths: " + StateControlller.deaths;

        audioController = GameObject.Find("AudioController");
        SceneManager.MoveGameObjectToScene(audioController, SceneManager.GetActiveScene());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown == true && skip == true){
            SceneManager.LoadScene("Start",LoadSceneMode.Single);
        }
    }
    void Daddy()
    {
        background.gameObject.SetActive(true);
        skip = true;
    }
    
}
