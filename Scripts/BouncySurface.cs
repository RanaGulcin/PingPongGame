using UnityEngine;

public class BouncySurface : MonoBehaviour
{

    public float carpma;

    private void OnCollisionEnter2D(Collision2D collision)//topun �arp�sma tepkisi fonsiyonu:
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if(ball != null)
        {
            // topa her �arpmada h�z kazand�rmak icin y�zeyin tersi y�n�nde kuvvet uygulama:
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.carpma);
        }
    }
}
