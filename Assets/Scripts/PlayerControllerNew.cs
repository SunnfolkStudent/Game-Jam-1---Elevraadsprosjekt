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
   public bool aBool;
   public bool oBool;
   public int eTeljar;
   public int gTeljar;
   public int hTeljar;
   public int lTeljar;
   public int vTeljar;
   

   public GameObject akeleie;
   public GameObject blåklokke;
   public GameObject cyathium;
   public GameObject dvergbjørk;
   public GameObject einer;
   public GameObject engeltrompet;
   public GameObject fjellmarikåpe;
   public GameObject gran;
   public GameObject geranium;
   public GameObject giftlilje;
   public GameObject hvitveis;
   public GameObject hjarteblome;
   public GameObject istevier;
   public GameObject jonsokkoll;
   public GameObject kattehale;
   public GameObject løvetann;
   public GameObject liljekonvall;
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
   public GameObject venus;
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
      aBool = false;
      oBool = false;
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
         else
         {
            if (aBool)
            {
               spawnObjectMethod(åkerbær);
               aBool = false;
            }
            aBool = true;
            saBool = false;
            oBool = false;
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
         if (aBool || oBool)
         {
            if (aBool)
            {
               spawnObjectMethod(ædelmynt);
               aBool = false;
            }

            if (oBool)
            {
               spawnObjectMethod(ørevier);
               oBool = false;
            }
         }
         else
         {
            if (eTeljar == 0)
            {
               spawnObjectMethod(einer);
               eTeljar = 1;
            }
            if (eTeljar == 1)
            {
               spawnObjectMethod(engeltrompet);
               eTeljar = 0;
            }
         }
        
      }

      if (_keyboard.fKey.wasPressedThisFrame)
      {
         spawnObjectMethod(fjellmarikåpe);
      }

      if (_keyboard.gKey.wasPressedThisFrame)
      {
         if (gTeljar is 0 or 2 or 4 or 6 or 8)
         {
            spawnObjectMethod(geranium);
            gTeljar += 1;
         }
         if (gTeljar is 1 or 3 or 5 or 7 or 9)
         {
            spawnObjectMethod(giftlilje);
            gTeljar += 1;
         }
         if (gTeljar == 10)
         {
            spawnObjectMethod(gran);
            gTeljar = 0;
         }
      }

      if (_keyboard.hKey.wasPressedThisFrame)
      {
         if (hTeljar == 0)
         {
            spawnObjectMethod(hjarteblome);
            hTeljar = 1;
         }

         if (hTeljar == 1)
         {
            spawnObjectMethod(hvitveis);
            hTeljar = 0;
         }
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
         if (lTeljar == 0)
         {
            spawnObjectMethod(løvetann);
            lTeljar = 1;
         }

         if (lTeljar == 1)
         {
            spawnObjectMethod(liljekonvall);
            lTeljar = 0;
         }
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
         oBool = true;
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

         if (sBool)
         {
            sBool = false;
         }
      }

      if (_keyboard.vKey.wasPressedThisFrame)
      {
         if (lTeljar == 0)
         {
            spawnObjectMethod(vivendel);
            lTeljar = 1;
         }
         if (lTeljar == 1)
         {
            spawnObjectMethod(venus);
            lTeljar = 0;
         }
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