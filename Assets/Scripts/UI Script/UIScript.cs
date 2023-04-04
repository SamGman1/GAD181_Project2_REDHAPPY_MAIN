using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MainScene
{
    public class UIScript : MonoBehaviour
    {
        public StatsTracker statsTracker;
        public float playerMoney = 0f;
        public TMP_Text playerMoneyText;

        public float redBerries = 0f;
        public TMP_Text redBerriesText;

        public float redJuice = 0f;
        public TMP_Text redJuiceText;

        public float redHappy = 0f;
        public TMP_Text redHappyText;


        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            playerMoney = statsTracker.playerMoney;
            playerMoneyText.SetText(""+ playerMoney.ToString("#0.00"));

            redBerries = statsTracker.redBerries;
            redBerriesText.SetText("" + redBerries);

            redJuice = statsTracker.redJuice;
            redJuiceText.SetText(redJuice.ToString("#0.00") + "L");

            redHappy = statsTracker.redHappy;
            redHappyText.SetText(redHappy.ToString("#0.00") + "L");

            
            
        }

        

    }
}
