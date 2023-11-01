using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
   private Keyboard _keyboard;

   public GameObject quad;
   
   public GameObject Akeleie;
   public GameObject Blåklokke;
   public GameObject Cyathium;
   public GameObject Dvergbjørk;
   public GameObject Einer;
   public GameObject Fjellmarikåpe;
   public GameObject Gran;
   public GameObject Hvitveis;
   public GameObject Istevier;
   public GameObject Jonsokkoll;
   public GameObject Kattehale;
   public GameObject Løvetann;
   public GameObject Marianøkleblom;
   public GameObject Nikkebrønsle;
   public GameObject Oksetunge;
   public GameObject Prestekrage;
   public GameObject Queen_of_the_Prairie;
   public GameObject Rose_Oransj;
   public GameObject Syrin;
   public GameObject Takrør;
   public GameObject Ugrasklokke;
   public GameObject Vivendel;
   public GameObject Wandflower;
   public GameObject Xeranthemum_annuum;
   public GameObject Yarrow;
   public GameObject Zantedeschia;
   public GameObject Ædelmynt;
   public GameObject Ørevier;
   public GameObject Åkerbær;

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

      if (_keyboard.cKey.wasPressedThisFrame)
      {
         spawnObjectMethodcyathium();
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
         
      Instantiate(Rose_Oransj, pos, Rose_Oransj.transform.rotation);
   }
   
   public void spawnObjectMethodBlueBell()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Blåklokke, pos, Blåklokke.transform.rotation);
   }

   public void spawnObjectMethodcyathium()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Cyathium, pos, Cyathium.transform.rotation);
   }


}
