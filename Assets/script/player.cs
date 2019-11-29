using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Text scoreText;
    public int count;
    private float speed = 6f;
    //  public GameObject GameOver;
    private Vector2 PointA;
    private Vector2 PointB;
    private bool touchStart = false;


    public AudioClip pointCollectSound;

  


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Camera.main.transform.position.y, Camera.main.transform.position.z));
           // Debug.Log("point a= "+PointA);
        }
        if (Input.GetMouseButton(0))
        {
            touchStart = true;
            PointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Camera.main.transform.position.y, Camera.main.transform.position.z));
          //  Debug.Log("point b= "+PointB);
        }
        else
        {
            touchStart = false;
        }
        

/*
       if (Input.GetAxisRaw("Horizontal")<0)
          {
              transform.Translate(Vector3.left * speed * Time.deltaTime);
              if(transform.position.x<= -3.42f)
              {
               transform.position = new Vector3(3.42f, transform.position.y, 0f); 
              }
          }

          if (Input.GetAxisRaw("Horizontal") > 0)
          {
              transform.Translate(Vector3.right * speed * Time.deltaTime);
              if (transform.position.x >= 3.42f)
              {
                  transform.position = new Vector3(-3.42f, transform.position.y, 0f);
              }
          }
        */    

    }
    private void FixedUpdate()
    {
        if (touchStart)
        {
            Vector2 offset = PointB - PointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction);
        }
    }
    void OnTriggerEnter2D(Collider2D coint)
    {
        if (coint.tag == "CoinCollect")
        {
            AudioSource PointSound = GetComponent<AudioSource>();
            PointSound.PlayOneShot(pointCollectSound);
            count++;
            scoreText.text = " " + count;
            Destroy(coint.gameObject);

        }
        if (coint.tag == "DestroyGameObject")
        {

            Destroy(this.gameObject);
            SceneManager.LoadScene("gameOverScene");
          //  GameOver.SetActive(false);

        }
    }
    void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.x <= -3.42f)
        {
            transform.position = new Vector3(3.42f, transform.position.y, 0f);
        }
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.x >= 3.42f)
        {
            transform.position = new Vector3(-3.42f, transform.position.y, 0f);
        }
    }

    
}
