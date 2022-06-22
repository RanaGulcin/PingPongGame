using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D rgb;//kalýtým alacak sýnýflarýn rigidbody özelliklerine ulasabilmeleri için protected olarak tanýmlandý.

    private void Awake()
    {
        //Rigidbody2D özelliklerini olusturulan rgb/rigidbody nesnesine atama:
        rgb = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        //raketlerin baslangýctaki pozizyonlarý ve hýzlarýný sýfýra getirme:
        rgb.position = new Vector2(rgb.position.x, 0.0f);
        rgb.velocity = Vector2.zero;
    }
}
