using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainScene
{

    public class BuyScript : MonoBehaviour
    {

        public GameObject berryText;

        public GameObject laptopMenu;

        public StatsTracker statsTracker;
        private bool inBuyZone = false;

        private bool inLaptop = false;
        


        public void OnTriggerStay(Collider other)
        {
            berryText.SetActive(true);
            inBuyZone = true;
        }
        public void OnTriggerExit(Collider other)
        {
            berryText.SetActive(false);
            inBuyZone = false;
        }
        void Update()
        {
            if (inBuyZone == true)
            {
                berryText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Time.timeScale = 0f;
                    laptopMenu.SetActive(true);
                    inLaptop = true;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }

                if (inLaptop == true)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        laptopMenu.SetActive(false);
                        inLaptop = false;
                        Time.timeScale = 1f;
                        Cursor.lockState = CursorLockMode.Locked;
                        Cursor.visible = false;
                    }
                }
            }
            
        }








        public void GetRedBerries()
        {
            if (statsTracker.playerMoney < 10f)
            {
                Debug.Log("You don't have enough money!");
            }
            else
            {
                statsTracker.playerMoney -= 10f;
                statsTracker.redBerries += 1;
            }
        }
        public void SellRedBerries()
        {
            if (statsTracker.redBerries < 1)
            {
                Debug.Log("You don't have enough Red Berries!");
            }
            else
            {
                statsTracker.playerMoney += 7f;
                statsTracker.redBerries -= 1;
            }
        }




    }
}
