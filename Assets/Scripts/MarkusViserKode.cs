using System;
using UnityEngine;

public class MarkusViserKode : MonoBehaviour
{
    public Camera cam;

    public Transform spawn;
    public Vector2 _spawnStartScale;
    public PlayerControllerNew player;

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
            /* spawn.localScale = new Vector3(spawn.localScale.x, spawn.localScale.y, spawn.localScale.z-1)*scaleMultiplier; */
        }
        else if (player.activeObjects.Count == 0)
        {
            print("reset");
            cam.orthographicSize -= 2 * Time.deltaTime;
            /* spawn.localScale = new Vector3(10.57f, 6.06f, 1); */
        }
        
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, 2, spawn.localScale.magnitude/4.5f);

        _spawnStartScale += new Vector2(0.3f, 0.15f)*Time.deltaTime;
        
        _spawnStartScale.x = Mathf.Clamp(_spawnStartScale.x, 1, 46);
        _spawnStartScale.y = Mathf.Clamp(_spawnStartScale.y, 1, 26);
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