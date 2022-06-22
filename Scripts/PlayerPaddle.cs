using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{

    private Vector2 direction;

    private void Update()
    {
        //oyuncu raketinin hareket yapýsýný olusturma:
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))//yukarý haraketi kosulu
        {
            direction = Vector2.up;
        }else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))//asagý haraketi kosulu
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;//haraket edilmedigindeki haraketsiz kalma komutu
        }
    }

    private void FixedUpdate()
    {
        if(direction.sqrMagnitude != 0)
        {
            rgb.AddForce(direction * this.speed);//oyuncu raketine fiziksel hýz/haraket ekleme

        }
    }
}
