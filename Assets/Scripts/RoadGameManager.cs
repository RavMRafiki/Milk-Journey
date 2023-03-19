using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RoadGameManager : MonoBehaviour
{
    public GameObject[] cars;
    public TextMeshProUGUI deathsText;


    void Start()
    {
        InvokeRepeating("SpawnCar",0.01f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        deathsText.text = "Deaths: " + StateControlller.deaths;
        
    }
    void SpawnCar()
    {
        int index = Random.Range(0,cars.Length);
        Instantiate(cars[index],cars[index].transform.position,transform.rotation);
    }
}
