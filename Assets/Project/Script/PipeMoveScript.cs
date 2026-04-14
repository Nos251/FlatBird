using UnityEngine;

namespace Project.Script
{
    public class PipeMoveScript : MonoBehaviour
    {
        public float speed = 2f;
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Obstacle"))
            {
                Debug.Log("Game Over");
            }
        }
    
        void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Trigger detected");
        }
    }
}
