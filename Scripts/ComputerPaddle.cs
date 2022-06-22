using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;//topun konumunu takip edebilmek için topun rgidbody öz. konsolda scripte çagýrdýk.
    private void FixedUpdate()
    {
        //topun bilgisayar raketine doðru hareket edip etmediðine bakma:
        if (this.ball.velocity.x > 0.0f)
        {
            //raketi topun yönünde hareket ettirme:
            if (this.ball.position.y > this.transform.position.y)//topun raketten yukardaysa
            {
                rgb.AddForce(Vector2.up * this.speed);//rakete yukarý yönde hýz kazandýrma
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
