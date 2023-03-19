using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MarketManager : MonoBehaviour
{
    public GameObject player;
    private bool old1B = true;
    private bool old2B = true;
    public GameObject old1;
    public GameObject old2;
    public TextMeshProUGUI deathsText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deathsText.text = "Deaths: " + StateControlller.deaths;
        if(player.transform.position.y > 0 && old1B == true){
            SpawnOld1();
        }
        if(player.transform.position.y > -2.5 && old2B == true){
        SpawnOld2();
        }
    }
    void SpawnOld1()
    {
        Instantiate(old1,old1.transform.position,old1.transform.rotation);
        old1B = false;
        Invoke("ResetTimer1",6f);
    }
    void SpawnOld2()
    {
        Instantiate(old2,old2.transform.position,old2.transform.rotation);
        old2B = false;
        Invoke("ResetTimer2",6f);

    }
    void ResetTimer1()
    {
            old1B = true;
    }
    void ResetTimer2()
    {
            old2B = true;
    }
}
