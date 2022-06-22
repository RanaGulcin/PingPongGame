using UnityEngine;

public class BouncySurface : MonoBehaviour
{

    public float carpma;

    private void OnCollisionEnter2D(Collision2D collision)//topun çarpýsma tepkisi fonsiyonu:
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if(ball != null)
        {
            // topa her çarpmada hýz kazandýrmak icin yüzeyin tersi yönünde kuvvet uygulama:
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.carpma);
        }
    }
}
