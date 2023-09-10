using UnityEngine;

public class BallController : MonoBehaviour
{
    public float kecepatanAwal = 5f; 
    private Rigidbody2D rb; 

    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

        
        MulaiBola();
    }

    private void MulaiBola()
    {
        
        Vector2 arahAwal = new Vector2(Random.Range(-1f, 1f), 1f).normalized;

       
        rb.velocity = arahAwal * kecepatanAwal;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bola"))
        {
            Destroy(collision.gameObject);
        }
    }


}



