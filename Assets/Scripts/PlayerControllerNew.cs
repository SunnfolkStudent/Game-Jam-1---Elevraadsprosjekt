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
   public bool egBool;
   public bool eBool;
   public int eTeljar;
   public int gTeljar;
   public int hTeljar;
   public int lTeljar;
   public int vTeljar;
   public bool AlleBools;
   

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
   public GameObject egg;

   public void Start()
   {
      c = quad.GetComponent<MeshCollider>();

      _keyboard = Keyboard.current;
      _æøå = GetComponent<Æøå>();
      sBool = false;
      saBool = false;
      aBool = false;
      oBool = false;
      egBool = false;
      AlleBools = false;
   }

   public void Update()
   {
      if (AlleBools)
      {
         sBool = false;
         saBool = false;
         aBool = false;
         oBool = false;
         eBool = false;
         egBool = false;
         
         AlleBools = false;
      }
      if (_keyboard.escapeKey.wasPressedThisFrame)
      {
         Application.Quit();
      }
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
         AlleBools = true;
      }

      if (_keyboard.cKey.wasPressedThisFrame)
      {
         spawnObjectMethod(cyathium);
         AlleBools = true;
      }

      if (_keyboard.dKey.wasPressedThisFrame)
      {
         spawnObjectMethod(dvergbjørk);
         AlleBools = true;
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
            AlleBools = true;
            eBool = true;
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
         AlleBools = true;
      }

      if (_keyboard.gKey.wasPressedThisFrame)
      {
         if (egBool)
         {
            spawnObjectMethod(egg);
            AlleBools = false;
         }
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

         if (eBool)
         {
            egBool = true;
            eBool = false;
         }
         else
         {
            AlleBools = true;
         }
         
      }

      if (_keyboard.hKey.wasPressedThisFrame)
      {
         AlleBools = true;
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
         AlleBools = true;
      }

      if (_keyboard.jKey.wasPressedThisFrame)
      {
         spawnObjectMethod(jonsokkoll);
         AlleBools = true;
      }

      if (_keyboard.kKey.wasPressedThisFrame)
      {
         spawnObjectMethod(kattehale);
         AlleBools = true;
      }

      if (_keyboard.lKey.wasPressedThisFrame)
      {
         AlleBools = true;
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
         AlleBools = true;
      }

      if (_keyboard.nKey.wasPressedThisFrame)
      {
         spawnObjectMethod(nikkebrønsle);
         AlleBools = true;
      }

      if (_keyboard.oKey.wasPressedThisFrame)
      {
         spawnObjectMethod(oksetunge);
         if (oBool == false)
         {
            oBool = true;
         }
         else
         {
            AlleBools = true;
         }
      }

      if (_keyboard.pKey.wasPressedThisFrame)
      {
         spawnObjectMethod(prestekrage);
         AlleBools = true;
      }

      if (_keyboard.qKey.wasPressedThisFrame)
      {
         spawnObjectMethod(queenOfThePrairie);
         AlleBools = true;
      }

      if (_keyboard.rKey.wasPressedThisFrame)
      {
         spawnObjectMethod(roseOransj);
         AlleBools = true;
      }

      if (_keyboard.sKey.wasPressedThisFrame)
      {
         spawnObjectMethod(syrin);
         if (sBool)
         {
            sBool = true;
         }
         else
         {
            sBool = true;
            AlleBools = true;
         }
      }

      if (_keyboard.tKey.wasPressedThisFrame)
      {
         spawnObjectMethod(takrør);
         AlleBools = true;
      }

      if (_keyboard.uKey.wasPressedThisFrame)
      {
         spawnObjectMethod(ursinia);

         if (saBool)
         {
            spawnObjectMethod(sau);
            saBool = false;
         }
         else
         {
            AlleBools = true;
         }
      }

      if (_keyboard.vKey.wasPressedThisFrame)
      {
         AlleBools = true;
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
         AlleBools = true;
      }

      if (_keyboard.xKey.wasPressedThisFrame)
      {
         spawnObjectMethod(xeranthemumAnnuum);
         AlleBools = true;
      }

      if (_keyboard.yKey.wasPressedThisFrame)
      {
         spawnObjectMethod(yarrow);
         AlleBools = true;
      }

      if (_keyboard.zKey.wasPressedThisFrame)
      {
         spawnObjectMethod(zantedeschia);
         AlleBools = true;
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