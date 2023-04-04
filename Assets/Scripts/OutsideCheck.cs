using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainScene
{
    public class OutsideCheck : MonoBehaviour
    {
        public bool outside = false;
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        {
            outside = true;
        }
    }
}
