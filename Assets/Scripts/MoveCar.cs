using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    private int lane;
    private SpriteRenderer sr;
    private float speed = 15;
    private int layer;
    private GameObject particle;
    void Start()
    {
        lane = Random.Range(0,4);
        sr = GetComponent<SpriteRenderer>();
        particle = this.gameObject.transform.GetChild(0).gameObject;
        if(lane<2){
        sr.flipX = true;
        }
        switch (lane)
        {
            case 0:
                particle.transform.Rotate(new Vector3(-180,0,0));
                particle.transform.position = new Vector2(-2.36f,particle.transform.position.y);
                sr.flipX = true;
                speed = -15;
                transform.position = new Vector2(12,3.5f);
                layer = 1;
                break;
            case 1:
                particle.transform.Rotate(new Vector3(-180,0,0));
                particle.transform.position = new Vector2(-2.36f,particle.transform.position.y);
                sr.flipX = true;
                speed = -20;
                transform.position = new Vector2(12,2f);
                layer = 2;
                break;
            case 2:
                speed = 20;
                transform.position = new Vector2(-12,-0.5f);
                layer = 3;
                break;
            case 3:
                speed = 15;
                transform.position = new Vector2(-12,-2f);
                layer = 4;
                break;
        }
        sr.sortingOrder = layer;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
        if(transform.position.x > 15 || transform.position.x < -15){
            Destroy(gameObject);
        }
    }
}
