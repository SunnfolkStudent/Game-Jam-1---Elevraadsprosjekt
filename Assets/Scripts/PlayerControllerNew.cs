using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class PlayerControllerNew : MonoBehaviour
{
   private Keyboard _keyboard;
   private Æøå _æøå;

   public GameObject quad;
   public MeshCollider c;
   public GameObject sau;
   public bool sBool;
   public bool saBool;

   public GameObject akeleie;
   public GameObject blåklokke;
   public GameObject cyathium;
   public GameObject dvergbjørk;
   public GameObject einer;
   public GameObject fjellmarikåpe;
   public GameObject gran;
   public GameObject hvitveis;
   public GameObject istevier;
   public GameObject jonsokkoll;
   public GameObject kattehale;
   public GameObject løvetann;
   public GameObject marianøkleblom;
   public GameObject nikkebrønsle;
   public GameObject oksetunge;
   public GameObject prestekrage;
   public GameObject queenOfThePrairie;
   public GameObject roseOransj;
   public GameObject syrin;
   public GameObject takrør;
   public GameObject ursinia;
   public GameObject vivendel;
   public GameObject wandflower;
   public GameObject xeranthemumAnnuum;
   public GameObject yarrow;
   public GameObject zantedeschia;
   public GameObject ædelmynt;
   public GameObject ørevier;
   public GameObject åkerbær;

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
         spawnObjectMethod(akeleie);

         if (sBool)
         {
            sBool = false;
            saBool = true;
         }
      }

      if (_keyboard.bKey.wasPressedThisFrame)
      {
         spawnObjectMethod(blåklokke);
      }

      if (_keyboard.cKey.wasPressedThisFrame)
      {
         spawnObjectMethod(cyathium);
      }

      if (_keyboard.dKey.wasPressedThisFrame)
      {
         spawnObjectMethod(dvergbjørk);
      }

      if (_keyboard.eKey.wasPressedThisFrame)
      {
         spawnObjectMethod(einer);
      }

      if (_keyboard.fKey.wasPressedThisFrame)
      {
         spawnObjectMethod(fjellmarikåpe);
      }

      if (_keyboard.gKey.wasPressedThisFrame)
      {
         spawnObjectMethod(gran);
      }

      if (_keyboard.hKey.wasPressedThisFrame)
      {
         spawnObjectMethod(hvitveis);
      }

      if (_keyboard.iKey.wasPressedThisFrame)
      {
         spawnObjectMethod(istevier);
      }

      if (_keyboard.jKey.wasPressedThisFrame)
      {
         spawnObjectMethod(jonsokkoll);
      }

      if (_keyboard.kKey.wasPressedThisFrame)
      {
         spawnObjectMethod(kattehale);
      }

      if (_keyboard.lKey.wasPressedThisFrame)
      {
         spawnObjectMethod(løvetann);
      }

      if (_keyboard.mKey.wasPressedThisFrame)
      {
         spawnObjectMethod(marianøkleblom);
      }

      if (_keyboard.nKey.wasPressedThisFrame)
      {
         spawnObjectMethod(nikkebrønsle);
      }

      if (_keyboard.oKey.wasPressedThisFrame)
      {
         spawnObjectMethod(oksetunge);
      }

      if (_keyboard.pKey.wasPressedThisFrame)
      {
         spawnObjectMethod(prestekrage);
      }

      if (_keyboard.qKey.wasPressedThisFrame)
      {
         spawnObjectMethod(queenOfThePrairie);
      }

      if (_keyboard.rKey.wasPressedThisFrame)
      {
         spawnObjectMethod(roseOransj);
      }

      if (_keyboard.sKey.wasPressedThisFrame)
      {
         spawnObjectMethod(syrin);
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

      if (_keyboard.tKey.wasPressedThisFrame)
      {
         spawnObjectMethod(takrør);
      }

      if (_keyboard.uKey.wasPressedThisFrame)
      {
         spawnObjectMethod(ursinia);

         if (saBool)
         {
            spawnObjectMethod(sau);
            saBool = false;
         }
      }

      if (_keyboard.vKey.wasPressedThisFrame)
      {
         spawnObjectMethod(vivendel);
      }

      if (_keyboard.wKey.wasPressedThisFrame)
      {
         spawnObjectMethod(wandflower);
      }

      if (_keyboard.xKey.wasPressedThisFrame)
      {
         spawnObjectMethod(xeranthemumAnnuum);
      }

      if (_keyboard.yKey.wasPressedThisFrame)
      {
         spawnObjectMethod(yarrow);
      }

      if (_keyboard.zKey.wasPressedThisFrame)
      {
         spawnObjectMethod(zantedeschia);
      }

   }


   public void spawnObjectMethod(GameObject prefab)
   {
      var screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
      var screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
      var pos = new Vector2(screenX, screenY);

      Instantiate(prefab, pos, prefab.transform.rotation);
   }
}