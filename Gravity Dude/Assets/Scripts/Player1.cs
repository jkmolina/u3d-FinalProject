using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public int hp = 100;
    public GameObject jugador1;
    public int xPosition;
    public int yPosition;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
