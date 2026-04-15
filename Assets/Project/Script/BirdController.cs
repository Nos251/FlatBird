using UnityEngine;
using UnityEngine.InputSystem;

namespace Project.Script
{
    public class BirdController : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        public float jumpForce;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            if (_rigidbody2D == null) Debug.LogError("BirdController: No Rigidbody2D found!");
        }

        // Update is called once per frame
        void Update()
        {
            // if (J'appuie sur la barre d'espace, le joueur "Bird" saute
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                _rigidbody2D.AddForceY(jumpForce, ForceMode2D.Impulse);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Game Over");
        }
    
        public enum GameState {Playing, GameOver}
        
        public void Die()
        {
            Time.timeScale = 0f;
        }

    }
}
