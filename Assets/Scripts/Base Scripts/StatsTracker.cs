using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainScene
{
    public class StatsTracker : MonoBehaviour
    {

        public float playerMoney = 0f;
        public int redBerries = 0;
        public float redJuice = 0f;
        public float redHappy = 0f;

       
        public float sellBaseYield = 102.80f;
        public float juiceBaseYield = 0.7f;
        public float happyBaseYield = 0.4f;

        public int berryCrushNumber = 1;
        public float juiceDistillNumber = 1f;
        public float happySellNumber = 1f;

        public float moneyMultiplier = 1f;
        public float juiceMultiplier = 1f;
        public float happyMultiplier = 1f;

        // Start is called before the first frame update
        void Start()
        {
            DontDestroyOnLoad(this.gameObject);
            playerMoney = 50f;

            sellBaseYield = 62.80f;
            juiceBaseYield = 0.7f;
            happyBaseYield = 0.4f;

            berryCrushNumber = 1;
            juiceDistillNumber = 1f;
            happySellNumber = 1f;

            moneyMultiplier = 1f;
            juiceMultiplier = 1f;
            happyMultiplier = 1f;
        }

        // Update is called once per frame
        void Update()
        {
            playerMoney = Mathf.Round(playerMoney * 10.0f) * 0.1f;
            redJuice = Mathf.Round(redJuice * 10.0f) * 0.1f;
            redHappy = Mathf.Round(redHappy * 10.0f) * 0.1f;
            
        }
    }
}
