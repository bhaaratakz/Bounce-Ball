using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float kecepatan = 10f;
    public float batasKiri = -5f; 
    public float batasKanan = 5f; 

    private void Update()
    {
        
        float gerakHorizontal = Input.GetAxis("Horizontal");

        
        Vector3 perpindahan = new Vector3(gerakHorizontal * kecepatan * Time.deltaTime, 0f, 0f);

        
        Vector3 posisiBaru = transform.position + perpindahan;
        posisiBaru.x = Mathf.Clamp(posisiBaru.x, batasKiri, batasKanan);
        transform.position = posisiBaru;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            
            float offset = transform.position.x - collision.transform.position.x;
            
            float arahX = offset / (GetComponent<Collider2D>().bounds.size.x / 2);
            
            float arahY = Mathf.Sqrt(1f - arahX * arahX);
            
            Vector2 arahPemantulan = new Vector2(arahX, arahY).normalized;

            collision.gameObject.GetComponent<Rigidbody2D>().velocity = arahPemantulan * collision.gameObject.GetComponent<BallController>().kecepatanAwal;
        }
    }
}
