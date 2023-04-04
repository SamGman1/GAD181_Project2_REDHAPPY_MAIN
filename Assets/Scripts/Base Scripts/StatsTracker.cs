using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainScene
{
    public class StatsTracker : MonoBehaviour
    {

        static public StatsTracker Instance;
        // Start is called before the first frame update
       

        public static float playerMoney = 0f;
        public static int redBerries = 0;
        public static float redJuice = 0f;
        public static float redHappy = 0f;

       
        public static float sellBaseYield = 0f;
        public static float juiceBaseYield = 0.7f;
        public static float happyBaseYield = 0.4f;

        public static int berryCrushNumber = 1;
        public static float juiceDistillNumber = 1f;
        public static float happySellNumber = 1f;

        public static float moneyMultiplier = 1f;
        public static float juiceMultiplier = 1f;
        public static float happyMultiplier = 1f;

        // Start is called before the first frame update
        void Start()
        {
            
            // start of new code
            if (Instance != null)
            {
                Destroy(this.gameObject);
                return;
            }
            // end of new code

            Instance = this;
            DontDestroyOnLoad(this.gameObject);

            playerMoney = 50f;

            sellBaseYield = 78.80f;
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
