using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainScene
{

    public class DistillScript : MonoBehaviour
    {

        public GameObject distillText;

        public StatsTracker statsTracker;
        private bool inDistillZone = false;

        public AudioSource distillSound;
        public AudioClip Distill;

        private void Start()
        {
            distillSound = GetComponent<AudioSource>();
        }


        public void OnTriggerEnter(Collider other)
        {
            distillText.SetActive(true);
            inDistillZone = true;
        }
        public void OnTriggerExit(Collider other)
        {
            distillText.SetActive(false);
            inDistillZone = false;
        }
        void Update()
        {
            if (inDistillZone == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (StatsTracker.redJuice >= 1f)
                    {
                        StatsTracker.redJuice -= StatsTracker.juiceDistillNumber;
                        StatsTracker.redHappy += StatsTracker.happySellNumber*(StatsTracker.happyBaseYield*StatsTracker.happyMultiplier);
                        Debug.Log("TESTING");
                        distillSound.PlayOneShot(Distill);
                    }
                    else
                    {
                        Debug.Log("You don't have enough RED JUICE!");
                    }
                }
            }

        }

    }
}