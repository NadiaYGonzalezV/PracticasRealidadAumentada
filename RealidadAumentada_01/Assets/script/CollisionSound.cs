using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
 
    
        public AudioClip collisionSound;
        private AudioSource audioSource;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                Debug.LogError("No AudioSource component found on this GameObject. Please add one.");
            }
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("OtherObject"))
            {
                if (audioSource != null && collisionSound != null)
                {
                    audioSource.PlayOneShot(collisionSound);
                }
            }
        }
    
}
