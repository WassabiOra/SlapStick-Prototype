using System.Diagnostics;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int health = 3;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > 5f) // Hard hit
        {
            health--;

            if (health <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        gameObject.SetActive(false);
    }
}

