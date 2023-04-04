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
            if (StatsTracker.playerMoney >= 500)
            {
                StatsTracker.juiceMultiplier += 0.2f;
                StatsTracker.playerMoney -= 500;
                strongHandsPrice.SetText("PURCHASED");
                strongHandsButton.SetActive(false);
            }
        }

        public void LargerMortar()
        {
            //Extra 20% of Juice from crushing.
            if (StatsTracker.playerMoney >= 700)
            {
                StatsTracker.berryCrushNumber *= 2;
                StatsTracker.playerMoney -= 700;
                largerMortarPrice.SetText("PURCHASED");
                largerMortarButton.SetActive(false);
            }
        }

        public void HigherConcentration()
        {
            if (StatsTracker.playerMoney >= 750)
            {
                StatsTracker.happyMultiplier += 0.1f;
                StatsTracker.playerMoney -= 700;
                higherConcentrationPrice.SetText("PURCHASED");
                higherConcentrationButton.SetActive(false);
            }
        }




    }
}
