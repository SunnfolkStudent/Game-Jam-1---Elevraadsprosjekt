using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
   private Keyboard _keyboard;
   private Æøå _æøå;

   public GameObject quad;
   public MeshCollider c;
   public GameObject Sau;
   public bool sBool;
   public bool saBool;
   
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
   public GameObject Ursinia;
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
      c = quad.GetComponent<MeshCollider>();
      
      _keyboard = Keyboard.current;
      _æøå = GetComponent<Æøå>();
      sBool = false;
      saBool = false;
   }

   public void Update()
   {
      if (_keyboard.aKey.wasPressedThisFrame)
      {
         spawnObjectMethod(Akeleie);
         
         if (sBool)
         {
            sBool = false;
            saBool = true;
         }
      }

      if (_keyboard.bKey.wasPressedThisFrame) { spawnObjectMethod(Blåklokke); }
      if (_keyboard.cKey.wasPressedThisFrame) { spawnObjectMethod(Cyathium); }
      if (_keyboard.dKey.wasPressedThisFrame) { spawnObjectMethod(Dvergbjørk); }
      if (_keyboard.eKey.wasPressedThisFrame) { spawnObjectMethod(Einer); }
      if (_keyboard.fKey.wasPressedThisFrame) { spawnObjectMethod(Fjellmarikåpe); }
      if (_keyboard.gKey.wasPressedThisFrame) { spawnObjectMethod(Gran); }
      if (_keyboard.hKey.wasPressedThisFrame) { spawnObjectMethod(Hvitveis); }
      if (_keyboard.iKey.wasPressedThisFrame) { spawnObjectMethod(Istevier); }
      if (_keyboard.jKey.wasPressedThisFrame) { spawnObjectMethod(Jonsokkoll); }
      if (_keyboard.kKey.wasPressedThisFrame) { spawnObjectMethod(Kattehale); }
      if (_keyboard.lKey.wasPressedThisFrame) { spawnObjectMethod(Løvetann); }
      if (_keyboard.mKey.wasPressedThisFrame) { spawnObjectMethod(Marianøkleblom); }
      if (_keyboard.nKey.wasPressedThisFrame) { spawnObjectMethod(Nikkebrønsle); }
      if (_keyboard.oKey.wasPressedThisFrame) { spawnObjectMethod(Oksetunge); }
      if (_keyboard.pKey.wasPressedThisFrame) { spawnObjectMethod(Prestekrage); }
      if (_keyboard.qKey.wasPressedThisFrame) { spawnObjectMethod(Queen_of_the_Prairie); }
      if (_keyboard.rKey.wasPressedThisFrame) { spawnObjectMethod(Rose_Oransj); }
      
      if (_keyboard.sKey.wasPressedThisFrame) 
      {
         spawnObjectMethod(Syrin);
         if (sBool == false)
         {
            sBool = true;
         }
         else
         {
            sBool = true;
            saBool = false;
         }
      }

      if (_keyboard.tKey.wasPressedThisFrame) { spawnObjectMethod(Takrør); }
      if (_keyboard.uKey.wasPressedThisFrame)
      {
         spawnObjectMethod(Ursinia);
         
         if (saBool)
         {
            spawnObjectMethod(Sau);
            saBool = false;
         }
      }
      if (_keyboard.vKey.wasPressedThisFrame) { spawnObjectMethod(Vivendel); }
      if (_keyboard.wKey.wasPressedThisFrame) { spawnObjectMethod(Wandflower); }
      if (_keyboard.xKey.wasPressedThisFrame) { spawnObjectMethod(Xeranthemum_annuum); }
      if (_keyboard.yKey.wasPressedThisFrame) { spawnObjectMethod(Yarrow); }
      if (_keyboard.zKey.wasPressedThisFrame) { spawnObjectMethod(Zantedeschia); }
      
   }
   
   
   public void spawnObjectMethod(GameObject prefab)
   {
      //MeshCollider c = quad.GetComponent<MeshCollider>();
      float screenX, screenY;
      Vector2 pos;
      
      screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(screenX, screenY);
         
      Instantiate(prefab, pos, prefab.transform.rotation);
   }
   
   
   /*
   public void spawnObjectMethodAkeleie()
   {
      //MeshCollider c = quad.GetComponent<MeshCollider>();
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
   */
}
