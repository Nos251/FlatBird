using UnityEngine;

namespace Project.Script
{
    public class TriggerScript : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Trigger detected");
        }
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    
    }
}
