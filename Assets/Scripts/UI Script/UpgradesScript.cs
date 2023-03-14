using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MainScene
{
    public class UpgradesScript : MonoBehaviour
    {

        public StatsTracker statsTracker;

        public TMP_Text strongHandsPrice;
        public GameObject strongHandsButton;

        public TMP_Text largerMortarPrice;
        public GameObject largerMortarButton;

        public TMP_Text higherConcentrationPrice;
        public GameObject higherConcentrationButton;

        void Start()
        {
            strongHandsPrice.SetText("$500");
            largerMortarPrice.SetText("$700");
            higherConcentrationPrice.SetText("$750");
        }

        public void StrongHands()
        {
            //Extra 20% of Juice from crushing.
            if (statsTracker.playerMoney >= 500)
            {
                statsTracker.juiceMultiplier += 0.2f;
                statsTracker.playerMoney -= 500;
                strongHandsPrice.SetText("PURCHASED");
                strongHandsButton.SetActive(false);
            }
        }

        public void LargerMortar()
        {
            //Extra 20% of Juice from crushing.
            if (statsTracker.playerMoney >= 700)
            {
                statsTracker.berryCrushNumber *= 2;
                statsTracker.playerMoney -= 700;
                largerMortarPrice.SetText("PURCHASED");
                largerMortarButton.SetActive(false);
            }
        }

        public void HigherConcentration()
        {
            if (statsTracker.playerMoney >= 750)
            {
                statsTracker.happyMultiplier += 0.1f;
                statsTracker.playerMoney -= 700;
                higherConcentrationPrice.SetText("PURCHASED");
                higherConcentrationButton.SetActive(false);
            }
        }




    }
}
