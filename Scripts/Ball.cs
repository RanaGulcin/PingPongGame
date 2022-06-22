using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D rgb;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody2D>();//topun Rigidbodyde belirlediðimiz fiziksel öz. rgb/rigidbody nesnesine atama
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        //topun baslangýc konumunu ve hýzýný sýfýr olarak belirleme.
        rgb.position = Vector2.zero;
        rgb.velocity = Vector2.zero;

    }

    public void AddStartingForce()
    {
        //topun rasgele soldan mý saðdan mý baþladýðýný belirleme:
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        //topun rasgele yukarý mý aþaðý mý gittiðini belirlemek
        //tamamen yatay hareket etmemesini saðlamak için 0,5 -> 1.0 arasýnda.
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);
        //topa hýz ekleme:
        Vector2 direction = new Vector2(x, y);
        rgb.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 kuvvet)
    {
       rgb.AddForce(kuvvet);
    }

    
}
