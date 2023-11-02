using System;
using UnityEngine;

public class MarkusViserKode : MonoBehaviour
{
    public Camera cam;

    public Transform spawn;
    public Vector2 _spawnStartScale;
    public PlayerController player;

    public float scaleMultiplier;

    private void Awake()
    {
        _spawnStartScale = spawn.localScale;
    }

    void Update()
    {
        
        scaleMultiplier = player.activeObjects.Count * Time.deltaTime / 30.14f;

        if (player.activeObjects.Count > 0)
        {
            print("grow");
            cam.orthographicSize += scaleMultiplier;
            spawn.localScale += new Vector2();
        }
        else if (player.activeObjects.Count == 0)
        {
            print("reset");
            cam.orthographicSize -= 2 * Time.deltaTime;
        }
        
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, 2, spawn.localScale.magnitude/4.5f);

        _spawnStartScale += new Vector2(0.3f, 0.15f)*Time.deltaTime;
        
        _spawnStartScale.x = Mathf.Clamp(_spawnStartScale.x, 1, 13);
        _spawnStartScale.y = Mathf.Clamp(_spawnStartScale.y, 1, 13);
        spawn.localScale = _spawnStartScale;
        
    }
}

/*
 *
 * cam.orthographicSize += 0.1f * Time.deltaTime;
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, 2, 13);

        _spawnStartScale += new Vector2(0.3f, 0.3f)*Time.deltaTime;
        _spawnStartScale.x = Mathf.Clamp(_spawnStartScale.x, 1, 13);
        _spawnStartScale.y = Mathf.Clamp(_spawnStartScale.y, 1, 13);
        spawn.localScale = _spawnStartScale;
 */