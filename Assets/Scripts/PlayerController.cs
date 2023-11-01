using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
   private Keyboard _keyboard;
   private Æøå _æøå;

   public GameObject quad;
   public GameObject sau;
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
      _keyboard = Keyboard.current;
      _æøå = GetComponent<Æøå>();
      sBool = false;
      saBool = false;
   }

   public void Update()
   {
      if (_keyboard.aKey.wasPressedThisFrame) { SpawnObjectMethodAkeleie(); }
      if (_keyboard.bKey.wasPressedThisFrame) { SpawnObjectMethodBlåklokke(); }
      if (_keyboard.cKey.wasPressedThisFrame) { SpawnObjectMethodCyathium(); }
      if (_keyboard.dKey.wasPressedThisFrame) { SpawnObjectMethodDvergbjørk(); }
      if (_keyboard.eKey.wasPressedThisFrame) { SpawnObjectMethodEiner(); }
      if (_keyboard.fKey.wasPressedThisFrame) { SpawnObjectMethodFjellmarikåpe(); }
      if (_keyboard.gKey.wasPressedThisFrame) { SpawnObjectMethodGran(); }
      if (_keyboard.hKey.wasPressedThisFrame) { SpawnObjectMethodHvitveis(); }
      if (_keyboard.iKey.wasPressedThisFrame) { SpawnObjectMethodIstevier(); }
      if (_keyboard.jKey.wasPressedThisFrame) { SpawnObjectMethodJonsokkoll(); }
      if (_keyboard.kKey.wasPressedThisFrame) { SpawnObjectMethodKattehale(); }
      if (_keyboard.lKey.wasPressedThisFrame) { SpawnObjectMethodLøvetann(); }
      if (_keyboard.mKey.wasPressedThisFrame) { SpawnObjectMethodMarianøkleblom(); }
      if (_keyboard.nKey.wasPressedThisFrame) { SpawnObjectMethodNikkebrønsle(); }
      if (_keyboard.oKey.wasPressedThisFrame) { SpawnObjectMethodOksetunge(); }
      if (_keyboard.pKey.wasPressedThisFrame) { SpawnObjectMethodPrestekrage(); }
      if (_keyboard.qKey.wasPressedThisFrame) { SpawnObjectMethodQueenOfThePrairie(); }
      if (_keyboard.rKey.wasPressedThisFrame) { SpawnObjectMethodRose(); }
      if (_keyboard.sKey.wasPressedThisFrame) { SpawnObjectMethodSyrin(); }
      if (_keyboard.tKey.wasPressedThisFrame) { SpawnObjectMethodTakrør(); }
      if (_keyboard.uKey.wasPressedThisFrame) { SpawnObjectMethodUrsinia(); }
      if (_keyboard.vKey.wasPressedThisFrame) { SpawnObjectMethodVivendel(); }
      if (_keyboard.wKey.wasPressedThisFrame) { SpawnObjectMethodWandflower(); }
      if (_keyboard.xKey.wasPressedThisFrame) { SpawnObjectMethodX(); }
      if (_keyboard.yKey.wasPressedThisFrame) { SpawnObjectMethodYarrow(); }
      if (_keyboard.zKey.wasPressedThisFrame) { SpawnObjectMethodZ(); }
   }
   
   public void SpawnObjectMethodAkeleie()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Akeleie, pos, Akeleie.transform.rotation);
      if (sBool)
      {
         sBool = false;
         saBool = true;
      }
   }
   
   public void SpawnObjectMethodBlåklokke()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Blåklokke, pos, Blåklokke.transform.rotation);
   }

   public void SpawnObjectMethodCyathium()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Cyathium, pos, Cyathium.transform.rotation);
   }
   
   public void SpawnObjectMethodDvergbjørk()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Dvergbjørk, pos, Dvergbjørk.transform.rotation);
   }
   
   public void SpawnObjectMethodEiner()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Einer, pos, Einer.transform.rotation);
   }
   
   public void SpawnObjectMethodFjellmarikåpe()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Fjellmarikåpe, pos, Fjellmarikåpe.transform.rotation);
   }
   
   public void SpawnObjectMethodGran()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Gran, pos, Gran.transform.rotation);
   }
   
   public void SpawnObjectMethodHvitveis()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Hvitveis, pos, Hvitveis.transform.rotation);
   }
   
   public void SpawnObjectMethodIstevier()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Istevier, pos, Istevier.transform.rotation);
   }
   
   public void SpawnObjectMethodJonsokkoll()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Jonsokkoll, pos, Jonsokkoll.transform.rotation);
   }
   
   public void SpawnObjectMethodKattehale()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Kattehale, pos, Kattehale.transform.rotation);
   }
   
   public void SpawnObjectMethodLøvetann()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Løvetann, pos, Løvetann.transform.rotation);
   }
   
   public void SpawnObjectMethodMarianøkleblom()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Marianøkleblom, pos, Marianøkleblom.transform.rotation);
   }
   
   public void SpawnObjectMethodNikkebrønsle()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Nikkebrønsle, pos, Nikkebrønsle.transform.rotation);
   }
   
   public void SpawnObjectMethodOksetunge()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Oksetunge, pos, Oksetunge.transform.rotation);
   }
   
   public void SpawnObjectMethodPrestekrage()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Prestekrage, pos, Prestekrage.transform.rotation);
   }
   
   public void SpawnObjectMethodQueenOfThePrairie()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Queen_of_the_Prairie, pos, Queen_of_the_Prairie.transform.rotation);
   }
   
   public void SpawnObjectMethodRose()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Rose_Oransj, pos, Rose_Oransj.transform.rotation);
   }
   
   public void SpawnObjectMethodSyrin()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Syrin, pos, Syrin.transform.rotation);
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

   private void SpawnObjectMethodTakrør()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Takrør, pos, Takrør.transform.rotation);
   }
   
   public void SpawnObjectMethodUrsinia()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Ursinia, pos, Ursinia.transform.rotation);
      if (saBool)
      {
         Instantiate(sau, pos, sau.transform.rotation);
         saBool = false;
      }
   }
   
   public void SpawnObjectMethodVivendel()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Vivendel, pos, Vivendel.transform.rotation);
   }
   
   public void SpawnObjectMethodWandflower()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Wandflower, pos, Wandflower.transform.rotation);
   }
   
   public void SpawnObjectMethodX()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Xeranthemum_annuum, pos, Xeranthemum_annuum.transform.rotation);
   }
   
   public void SpawnObjectMethodYarrow()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Yarrow, pos, Yarrow.transform.rotation);
   }
   
   public void SpawnObjectMethodZ()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Zantedeschia, pos, Zantedeschia.transform.rotation);
   }
   
   public void spawnObjectMethodÆdelmynt()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Ædelmynt, pos, Ædelmynt.transform.rotation);
   }
   
   public void spawnObjectMethodØrevier()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Ørevier, pos, Ørevier.transform.rotation);
   }
   
   public void spawnObjectMethodÅkerbær()
   {
      MeshCollider c = quad.GetComponent<MeshCollider>();
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x); 
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);
      Instantiate(Åkerbær, pos, Åkerbær.transform.rotation);
   }
}
