using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D rgb;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody2D>();//topun Rigidbodyde belirledi�imiz fiziksel �z. rgb/rigidbody nesnesine atama
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        //topun baslang�c konumunu ve h�z�n� s�f�r olarak belirleme.
        rgb.position = Vector2.zero;
        rgb.velocity = Vector2.zero;

    }

    public void AddStartingForce()
    {
        //topun rasgele soldan m� sa�dan m� ba�lad���n� belirleme:
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        //topun rasgele yukar� m� a�a�� m� gitti�ini belirlemek
        //tamamen yatay hareket etmemesini sa�lamak i�in 0,5 -> 1.0 aras�nda.
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);
        //topa h�z ekleme:
        Vector2 direction = new Vector2(x, y);
        rgb.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 kuvvet)
    {
       rgb.AddForce(kuvvet);
    }

    
}
