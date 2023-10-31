using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
   private Keyboard _keyboard;

   public GameObject quad;
   public GameObject Rose_Orange;
   public GameObject Blue_Bell;

   public void Start()
   {
      _keyboard = Keyboard.current;
   }

   public void Update()
   {
      if (_keyboard.rKey.wasPressedThisFrame)
      {
         spawnObjectMethodRose();
      }

      if (_keyboard.bKey.wasPressedThisFrame)
      {
         spawnObjectMethodBlueBell();
      }
   }

   public void spawnObjectMethodRose()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      
         screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
         screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
         pos = new Vector2(screenX, screenY);
         
         Instantiate(Rose_Orange, pos, Rose_Orange.transform.rotation);
      
   }
   
   public void spawnObjectMethodBlueBell()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Blue_Bell, pos, Blue_Bell.transform.rotation);
      
   }


}
