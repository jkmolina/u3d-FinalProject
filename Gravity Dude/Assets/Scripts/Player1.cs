using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public int hp = 100;
    public GameObject jugador1;
    public int xPosition;
    public int yPosition;
    public int xspeed;
    public int yspeed;
    public Rigidbody2D rb;
    Vector2 pos;
    public bool isGrounded;
    void Start()
    {
        Vector2 pos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(xspeed, yspeed);
        if (isGrounded)
        {
            changeYourGravity();
        }
    }
    public void TakeDamage(int amount)
    {
        hp -= amount;
        if (hp <= 0)
        {
            //Destroy(gameObject);
            pos.x = xPosition;
            pos.y = yPosition;
            transform.position = pos;
        }
    }
    public void changeYourGravity()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            yspeed = -yspeed;
        }
    }

    public void changeOtherGravity() { 
        //buscar la velocidad y del otro y ponerla negativa
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Debug.Log("awake");
        }
    }
}
