using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    public float minY = -5.0f; 

    
    void Start()
    {

    }

    
    void Update()
    {
        if (transform.position.y < minY)
        {
            transform.position = Vector3.zero; 
        }
    }
}
