using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StateControlller : MonoBehaviour
{
    public static int deaths = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void AddDeaths()
    {
        StateControlller.deaths++;
        Debug.Log(StateControlller.deaths);
        
    }
}
