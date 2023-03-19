using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;
    public TextMeshProUGUI deathsText;

    void Start()
    {
        InvokeRepeating("SpawnEnemy",0.01f,0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        deathsText.text = "Deaths: " + StateControlller.deaths;
        
    }
    void SpawnEnemy()
    {
        int index = Random.Range(0,enemies.Length);
        Instantiate(enemies[index],enemies[index].transform.position,transform.rotation);
    }
}
