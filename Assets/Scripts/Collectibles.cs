using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Is the player colliding with the collectible?
        if(collision.gameObject.tag == "Player")
        {
            // Destroy the collectible.
            Destroy(gameObject);
        }
    }
}
