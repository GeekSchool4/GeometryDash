using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse_Platform : MonoBehaviour
{
  [SerializeField] private float pulseVelocity = 3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * rb.velocity.x + Vector2.up * pulseVelocity;
    }
    

}
