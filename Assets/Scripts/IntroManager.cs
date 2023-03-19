using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    private bool skip = false;
    void Start()
    {
        Invoke("Kitchen",1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown == true && skip == true){
        SceneManager.LoadScene("Kitchen",LoadSceneMode.Single);
        }
    }
    void Kitchen()
    {
        skip = true;
    }
}
