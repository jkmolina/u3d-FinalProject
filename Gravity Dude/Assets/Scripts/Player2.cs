using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public int hp = 100;
    public GameObject jugador2;
    public int xPosition;
    public int yPosition;
    Vector2 pos;
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
            pos.x = xPosition;
            pos.y = yPosition;
            transform.position = pos;
        }
    }
}
