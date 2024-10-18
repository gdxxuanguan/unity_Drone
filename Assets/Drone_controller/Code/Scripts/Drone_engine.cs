using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myinputs
{
    [RequireComponent(typeof(BoxCollider))]
    public class Drone_engine : MonoBehaviour,IEngine
    {
        [Header("Engine proporties")]
        [SerializeField] private float maxPower = 4f;
        public void InitEngine()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEngine()
        {
            throw new System.NotImplementedException();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
