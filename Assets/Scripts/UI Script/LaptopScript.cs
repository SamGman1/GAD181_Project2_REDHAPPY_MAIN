using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MainScene
{
    public class LaptopScript : MonoBehaviour
    {

        public StatsTracker statsTracker;

        public GameObject buyScreen;
        public GameObject emailScreen;
        public GameObject upgradeScreen;
        public GameObject automationScreen;

        public float playerMoney = 0f;
        public TMP_Text playerMoneyText;

        public bool inLaptop = false;
        public bool inStore = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            playerMoney = StatsTracker.playerMoney;
            playerMoneyText.SetText("$" + playerMoney);
        }

        public void Store()
        {
            inStore = true;
            emailScreen.SetActive(false);
            upgradeScreen.SetActive(false);
            automationScreen.SetActive(false);
            buyScreen.SetActive(true);

        }
        public void Upgrades()
        {
            emailScreen.SetActive(false);
            upgradeScreen.SetActive(true);
            automationScreen.SetActive(false);
            buyScreen.SetActive(false);
        }
        public void Mail()
        {
            emailScreen.SetActive(true);
            upgradeScreen.SetActive(false);
            automationScreen.SetActive(false);
            buyScreen.SetActive(false);
        }
        public void Automation()
        {
            emailScreen.SetActive(false);
            upgradeScreen.SetActive(false);
            automationScreen.SetActive(true);
            buyScreen.SetActive(false);
        }
    }
}
