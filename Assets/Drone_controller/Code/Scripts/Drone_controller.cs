using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Myinputs
{
    [RequireComponent(typeof(Drone_inputs))]
    public class Drone_controller : Base_Rigidbody
    {
        [Header("Drone Control Properties")]
        [SerializeField] private float minMaxPitch = 30f;
        [SerializeField] private float minMaxRoll = 30f;
        [SerializeField] private float yawPower = 4f;
        private Drone_inputs inputs;
        private List<IEngine> engins = new List<IEngine>();


        // Start is called before the first frame update
        void Start()
        {
            inputs = GetComponent<Drone_inputs>();
            engins = GetComponentsInChildren<IEngine>().ToList<IEngine>();
        }


        protected override void HandlePhysics()
        {
            HandleEngines();
            HandleControls();
        }

        protected virtual void HandleEngines()
        {
            rb.AddForce(Vector3.up * (rb.mass * Physics.gravity.magnitude));
        }

        protected virtual void HandleControls()
        {

        }

    }
}
