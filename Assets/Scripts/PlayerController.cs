using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
   private Keyboard _keyboard;

   public GameObject quad;
   public GameObject Sau;
   public bool s_Bool;
   public bool s_a_Bool;
   
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
   [FormerlySerializedAs("Urisina")] public GameObject Ursinia;
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
      s_Bool = false;
      s_a_Bool = false;
   }

   public void Update()
   {
      if (_keyboard.aKey.wasPressedThisFrame)
      {
         spawnObjectMethodAkeleie();
      }

      if (_keyboard.bKey.wasPressedThisFrame)
      {
         spawnObjectMethodBlåklokke();
      }

      if (_keyboard.cKey.wasPressedThisFrame)
      {
         spawnObjectMethodCyathium();
      }

      if (_keyboard.dKey.wasPressedThisFrame)
      {
         spawnObjectMethodDvergbjørk();
      }

      if (_keyboard.eKey.wasPressedThisFrame)
      {
         spawnObjectMethodEiner();
      }

      if (_keyboard.fKey.wasPressedThisFrame)
      {
         spawnObjectMethodFjellmarikåpe();
      }

      if (_keyboard.gKey.wasPressedThisFrame)
      {
         spawnObjectMethodGran();
      }

      if (_keyboard.hKey.wasPressedThisFrame)
      {
         spawnObjectMethodHvitveis();
      }

      if (_keyboard.iKey.wasPressedThisFrame)
      {
         spawnObjectMethodIstevier();
      }

      if (_keyboard.jKey.wasPressedThisFrame)
      {
         spawnObjectMethodJonsokkoll();
      }

      if (_keyboard.kKey.wasPressedThisFrame)
      {
         spawnObjectMethodKattehale();
      }

      if (_keyboard.lKey.wasPressedThisFrame)
      {
         spawnObjectMethodLøvetann();
      }

      if (_keyboard.mKey.wasPressedThisFrame)
      {
         spawnObjectMethodMarianøkleblom();
      }

      if (_keyboard.nKey.wasPressedThisFrame)
      {
         spawnObjectMethodNikkebrønsle();
      }

      if (_keyboard.oKey.wasPressedThisFrame)
      {
         spawnObjectMethodOksetunge();
      }

      if (_keyboard.pKey.wasPressedThisFrame)
      {
         spawnObjectMethodPrestekrage();
      }

      if (_keyboard.qKey.wasPressedThisFrame)
      {
         spawnObjectMethodQueen_of_the_Prairie();
      }
      
      if (_keyboard.rKey.wasPressedThisFrame)
      {
         spawnObjectMethodRose();
      }

      if (_keyboard.sKey.wasPressedThisFrame)
      {
         spawnObjectMethodSyrin();
      }

      if (_keyboard.tKey.wasPressedThisFrame)
      {
         spawnObjectMethodTakrør();
      }

      if (_keyboard.uKey.wasPressedThisFrame)
      {
         spawnObjectMethodUrsinia();
      }

      if (_keyboard.vKey.wasPressedThisFrame)
      {
         spawnObjectMethodVivendel();
      }

      if (_keyboard.wKey.wasPressedThisFrame)
      {
         spawnObjectMethodWandflower();
      }

      if (_keyboard.xKey.wasPressedThisFrame)
      {
         spawnObjectMethodX();
      }

      if (_keyboard.yKey.wasPressedThisFrame)
      {
         spawnObjectMethodYarrow();
      }

      if (_keyboard.zKey.wasPressedThisFrame)
      {
         spawnObjectMethodZ();
      }
      
   }
   
   public void spawnObjectMethodAkeleie()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Akeleie, pos, Akeleie.transform.rotation);

      if (s_Bool)
      {
         s_Bool = false;
         s_a_Bool = true;
      }
   }
   
   public void spawnObjectMethodBlåklokke()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Blåklokke, pos, Blåklokke.transform.rotation);
   }

   public void spawnObjectMethodCyathium()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Cyathium, pos, Cyathium.transform.rotation);
   }
   
   public void spawnObjectMethodDvergbjørk()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Dvergbjørk, pos, Dvergbjørk.transform.rotation);
   }
   
   public void spawnObjectMethodEiner()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Einer, pos, Einer.transform.rotation);
   }
   
   public void spawnObjectMethodFjellmarikåpe()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Fjellmarikåpe, pos, Fjellmarikåpe.transform.rotation);
   }
   
   public void spawnObjectMethodGran()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Gran, pos, Gran.transform.rotation);
   }
   
   public void spawnObjectMethodHvitveis()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Hvitveis, pos, Hvitveis.transform.rotation);
   }
   
   public void spawnObjectMethodIstevier()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Istevier, pos, Istevier.transform.rotation);
   }
   
   public void spawnObjectMethodJonsokkoll()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Jonsokkoll, pos, Jonsokkoll.transform.rotation);
   }
   
   public void spawnObjectMethodKattehale()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Kattehale, pos, Kattehale.transform.rotation);
   }
   
   public void spawnObjectMethodLøvetann()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Løvetann, pos, Løvetann.transform.rotation);
   }
   
   public void spawnObjectMethodMarianøkleblom()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Marianøkleblom, pos, Marianøkleblom.transform.rotation);
   }
   
   public void spawnObjectMethodNikkebrønsle()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Nikkebrønsle, pos, Nikkebrønsle.transform.rotation);
   }
   
   public void spawnObjectMethodOksetunge()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Oksetunge, pos, Oksetunge.transform.rotation);
   }
   
   public void spawnObjectMethodPrestekrage()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Prestekrage, pos, Prestekrage.transform.rotation);
   }
   
   public void spawnObjectMethodQueen_of_the_Prairie()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Queen_of_the_Prairie, pos, Queen_of_the_Prairie.transform.rotation);
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
   
   public void spawnObjectMethodSyrin()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();

      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
         
      Instantiate(Syrin, pos, Syrin.transform.rotation);
      if (s_Bool == false)
      {
         s_Bool = true;
      }
      else
      {
         s_Bool = true;
         s_a_Bool = false;
      }
   }

   private void spawnObjectMethodTakrør()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();

      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
         
      Instantiate(Takrør, pos, Takrør.transform.rotation);
   }
   
   public void spawnObjectMethodUrsinia()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Ursinia, pos, Ursinia.transform.rotation);
      
      if (s_a_Bool)
      {
         Instantiate(Sau, pos, Sau.transform.rotation);
         s_a_Bool = false;
      }
   }
   
   public void spawnObjectMethodVivendel()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Vivendel, pos, Vivendel.transform.rotation);
   }
   
   public void spawnObjectMethodWandflower()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Wandflower, pos, Wandflower.transform.rotation);
   }
   
   public void spawnObjectMethodX()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Xeranthemum_annuum, pos, Xeranthemum_annuum.transform.rotation);
   }
   
   public void spawnObjectMethodYarrow()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Yarrow, pos, Yarrow.transform.rotation);
   }
   
   public void spawnObjectMethodZ()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Zantedeschia, pos, Zantedeschia.transform.rotation);
   }
   
   public void spawnObjectMethodÆdelmynt()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Ædelmynt, pos, Ædelmynt.transform.rotation);
   }
   
   public void spawnObjectMethodØrevier()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Ørevier, pos, Ørevier.transform.rotation);
   }
   
   public void spawnObjectMethodÅkerbær()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(Åkerbær, pos, Åkerbær.transform.rotation);
   }
}
