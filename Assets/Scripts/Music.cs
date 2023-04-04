using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainScene
{
    public class Music : MonoBehaviour
    {

        static public Music Instance;

        public StatsTracker statsTracker;
        public BuyScript buyScript;
        public LaptopScript laptopScript;
        public OutsideCheck outsideCheck;
        public SellScript sellScript;
        

        public AudioSource phoneCall;
        public AudioClip Call1;
        public AudioClip Call2;
        public AudioClip Call3;
        public AudioClip Call4;
        public AudioClip Call5;
        public AudioClip Call6;
        public AudioClip Call7;
        public AudioClip Call8;

        static public bool call1Done = false;
        static public bool call2Done = false;
        static public bool call3Done = false;
        static public bool call4Done = false;
        static public bool call5Done = false;
        static public bool call6Done = false;
        static public bool call7Done = false;
        static public bool call8Done = false;

        // Start is called before the first frame update
        void Start()
        {
            DontDestroyOnLoad(this.gameObject);
            if (Instance != null)
            {
                Destroy(this.gameObject);
                return;
            }
            // end of new code

            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            
            

        }

        // Update is called once per frame
        void Update()
        {

            if (call1Done == false)
            {
                call1Done = true;
                phoneCall.PlayOneShot(Call1);
            }

            if (buyScript.inLaptop == true)
            {
                if (call2Done == false)
                {
                    phoneCall.Stop();
                    call2Done = true;
                    phoneCall.PlayOneShot(Call2);
                }
            }

            if (laptopScript.inStore == true)
            {
                if (call3Done == false)
                {
                    phoneCall.Stop();
                    call3Done = true;
                    phoneCall.PlayOneShot(Call3);
                }
            }

            if (StatsTracker.playerMoney <= 0 && buyScript.inLaptop == false)
            {
                if (call4Done == false)
                {
                    phoneCall.Stop();
                    call4Done = true;
                    phoneCall.PlayOneShot(Call4);
                }
            }

            if (StatsTracker.redBerries <= 0 && call4Done == true)
            {
                if (call5Done == false)
                {
                    phoneCall.Stop();
                    call5Done = true;
                    phoneCall.PlayOneShot(Call5);
                }
            }

            if (StatsTracker.redHappy >= 1)
            {
                if (call6Done == false)
                {
                    phoneCall.Stop();
                    call6Done = true;
                    phoneCall.PlayOneShot(Call6);
                }
            }

            if (outsideCheck.outside == true)
            {
                if (call7Done == false)
                {
                    phoneCall.Stop();
                    call7Done = true;
                    phoneCall.PlayOneShot(Call7);
                }
            }
            if (sellScript.firstSell == true)
            {
                if (call8Done == false)
                {
                    phoneCall.Stop();
                    call8Done = true;
                    phoneCall.PlayOneShot(Call8);
                }
            }

        }
    }
}
