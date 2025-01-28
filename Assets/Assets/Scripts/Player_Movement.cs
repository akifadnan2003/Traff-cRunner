using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Transform transform;
    public float speed = 5f;
    public float rotationSpeed= 5f; 

    public Score_Manager scoreValue;

    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Clamp();        
    }

    void Movement(){
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,-40),rotationSpeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,40),rotationSpeed*Time.deltaTime);
        }

        if(transform.rotation.z!=90){
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,0),rotationSpeed*Time.deltaTime);
        }
    }
    void Clamp(){
        Vector3 pos= transform.position;
        pos.x = Mathf.Clamp(pos.x, -1.8f, 1.8f);
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag=="Cars"){
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        if(collision.gameObject.tag=="Coin"){
           scoreValue.score+=10;
            Destroy(collision.gameObject);

        }
    }
}