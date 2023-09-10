using UnityEngine;


public class BrickDestroyer : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Ball")) return;
        Destroy(gameObject);
    }
}

