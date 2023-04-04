using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainScene
{

    public class SellScript : MonoBehaviour
    {

        public GameObject sellText;
        public bool firstSell = false;

        public StatsTracker statsTracker;
        private bool inSellZone = false;

        public AudioSource sellSound;
        public AudioClip Sell;

        public void OnTriggerEnter(Collider other)
        {
            sellText.SetActive(true);
            inSellZone = true;
        }
        public void OnTriggerExit(Collider other)
        {
            sellText.SetActive(false);
            inSellZone = false;
        }

        void Update()
        {
            if (inSellZone == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (StatsTracker.redHappy >= 1f)
                    {
                        firstSell = true;
                        StatsTracker.redHappy -= StatsTracker.happySellNumber;
                        StatsTracker.playerMoney += StatsTracker.happySellNumber*(StatsTracker.sellBaseYield*StatsTracker.moneyMultiplier);
                        Debug.Log("TESTING");
                        sellSound.PlayOneShot(Sell);
                    }
                    else
                    {
                        Debug.Log("You don't have enough RED HAPPY!");
                    }
                }
            }

        }
    }
}
