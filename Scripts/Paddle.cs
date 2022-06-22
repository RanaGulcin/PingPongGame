using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D rgb;//kal�t�m alacak s�n�flar�n rigidbody �zelliklerine ulasabilmeleri i�in protected olarak tan�mland�.

    private void Awake()
    {
        //Rigidbody2D �zelliklerini olusturulan rgb/rigidbody nesnesine atama:
        rgb = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        //raketlerin baslang�ctaki pozizyonlar� ve h�zlar�n� s�f�ra getirme:
        rgb.position = new Vector2(rgb.position.x, 0.0f);
        rgb.velocity = Vector2.zero;
    }
}
