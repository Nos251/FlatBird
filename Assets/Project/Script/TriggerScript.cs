using UnityEngine;

namespace Project.Script
{
    public class TriggerScript : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Trigger detected");
        }
    }
}
