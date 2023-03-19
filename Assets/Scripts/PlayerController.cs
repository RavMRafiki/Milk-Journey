using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float inputVertical;
    public float inputHorizontal;
    public float speed = 5;
    private Animator playerAnim;
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A)) {
            inputHorizontal = -1;
            playerAnim.SetBool("LeftWalk",true);
            } else if (Input.GetKeyUp(KeyCode.A)){
                playerAnim.SetBool("LeftWalk",false);
            }
        if(Input.GetKey(KeyCode.D)) {
            inputHorizontal = 1;
            playerAnim.SetBool("RightWalk",true);
            } else if (Input.GetKeyUp(KeyCode.D)){
                playerAnim.SetBool("RightWalk",false);
            }
        if(Input.GetKey(KeyCode.S)) {
            inputVertical = -1;
            playerAnim.SetBool("FrontWalk",true);
            } else if (Input.GetKeyUp(KeyCode.S)){
                playerAnim.SetBool("FrontWalk",false);
            }
        if(Input.GetKey(KeyCode.W)) {
            inputVertical = 1;
            playerAnim.SetBool("BackWalk",true);
            } else if (Input.GetKeyUp(KeyCode.W)){
                playerAnim.SetBool("BackWalk",false);
            }
        transform.Translate(((Vector2.right* inputHorizontal)+(Vector2.up * inputVertical)).normalized * speed * Time.deltaTime);
        inputHorizontal = 0;
        inputVertical = 0;
        if(transform.position.y>1 && SceneManager.GetActiveScene().name == "Kitchen"){
            SceneManager.LoadScene("Road",LoadSceneMode.Single);
        } else if(transform.position.y>4 && SceneManager.GetActiveScene().name == "Road"){
            SceneManager.LoadScene("SuperMarket",LoadSceneMode.Single);
        } else if(transform.position.y>2&& transform.position.x < -8 && SceneManager.GetActiveScene().name == "SuperMarket"){
            SceneManager.LoadScene("Outro",LoadSceneMode.Single);
        }
        if(transform.position.y<-4.5f){
            transform.position = new Vector2(transform.position.x,-4.5f);
        }
        if(transform.position.x<-8){
            transform.position = new Vector2(-8,transform.position.y);
        }
        if(transform.position.x>8){
            transform.position = new Vector2(8,transform.position.y);
        }

    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Collision");    
        StateControlller.AddDeaths();
        try
        {
        GameObject.Find("AudioController").GetComponent<StartScreen>().PlayCrashSound();
        }
        catch
        {
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
