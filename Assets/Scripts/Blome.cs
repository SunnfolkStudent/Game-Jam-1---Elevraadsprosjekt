using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blome : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        // Check if the collision is with the player character.
        if (collision.gameObject.CompareTag("Sau"))
        {
            Destroy(gameObject);
        }
    }
}
