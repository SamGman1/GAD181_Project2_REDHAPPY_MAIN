using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainScene
{

    public class CrushScript : MonoBehaviour
    {

        public GameObject crushText;

        public StatsTracker statsTracker;
        private bool inCrushZone = false;

        public AudioSource crushSound;
        public AudioClip Crush;

        private void Start()
        {
            crushSound = GetComponent<AudioSource>();
        }
        public void OnTriggerEnter(Collider other)
        {
            crushText.SetActive(true);
            inCrushZone = true;
        }
        public void OnTriggerExit(Collider other)
        {
            crushText.SetActive(false);
            inCrushZone = false;
        }

        void Update()
        {
            if (inCrushZone == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (StatsTracker.redBerries >= 1)
                    {
                        if (StatsTracker.berryCrushNumber > StatsTracker.redBerries)
                        {
                            StatsTracker.redBerries -= 1;
                            StatsTracker.redJuice += 1 * (StatsTracker.juiceBaseYield * StatsTracker.juiceMultiplier);
                            Debug.Log("TESTING");
                            crushSound.PlayOneShot(Crush);
                        }
                        else
                        {
                            StatsTracker.redBerries -= StatsTracker.berryCrushNumber;
                            StatsTracker.redJuice += StatsTracker.berryCrushNumber * (StatsTracker.juiceBaseYield * StatsTracker.juiceMultiplier);
                            Debug.Log("TESTING");
                            crushSound.PlayOneShot(Crush);
                        }
                    }
                    else
                    {
                        Debug.Log("You don't have enough RED BERRIES!");
                    }
                }
            }

        }
    }
}
