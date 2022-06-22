using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;//topun konumunu takip edebilmek i�in topun rgidbody �z. konsolda scripte �ag�rd�k.
    private void FixedUpdate()
    {
        //topun bilgisayar raketine do�ru hareket edip etmedi�ine bakma:
        if (this.ball.velocity.x > 0.0f)
        {
            //raketi topun y�n�nde hareket ettirme:
            if (this.ball.position.y > this.transform.position.y)//topun raketten yukardaysa
            {
                rgb.AddForce(Vector2.up * this.speed);//rakete yukar� y�nde h�z kazand�rma
            }
            else
            {
              rgb.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            //top diger alandayken raketi ortaya getirme:
            if (this.transform.position.y > 0.0f)
            {
               rgb.AddForce(Vector2.down * this.speed);
            }
            else 
            {
                rgb.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
