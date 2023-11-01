using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blome : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sau"))
        {
            Destroy(gameObject);
        }
    }
}
