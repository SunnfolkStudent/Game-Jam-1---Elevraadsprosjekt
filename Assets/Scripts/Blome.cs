using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blome : MonoBehaviour
{

    private PlayerControllerNew _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerNew>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sau"))
        {
            _player.activeObjects.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
