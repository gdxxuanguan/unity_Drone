using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myinputs
{
    [RequireComponent(typeof(Drone_inputs))]
    public class Drone_controller : Base_Rigidbody
    {
        [Header("Drone Properties")]
        [SerializeField] private float minMaxPitch = 30f;
        [SerializeField] private float minMaxRoll = 30f;
        [SerializeField] private float yawPower = 4f;
        [SerializeField] private Drone_inputs inputs;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void HandlePhysics()
        {
            HandleEngines();
            HandleControls();
        }

        protected virtual void HandleEngines()
        {

        }

        protected virtual void HandleControls()
        {

        }

    }
}
