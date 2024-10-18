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
        private float lerpSpeed = 2f;
        private Drone_inputs inputs;
        private List<IEngine> engins = new List<IEngine>();
        private float finalPitch;
        private float finalRoll;
        private float finalYaw;
        private float yaw;


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
            //rb.AddForce(Vector3.up * (rb.mass * Physics.gravity.magnitude));
            foreach(IEngine engine in engins)
            {
                engine.UpdateEngine(rb,inputs);
            }

        }

        protected virtual void HandleControls()
        {
            float pitch = inputs.Cyclic.y * minMaxPitch;
            float roll = -inputs.Cyclic.x * minMaxRoll;
            yaw += inputs.Pedals * yawPower;

            finalPitch = Mathf.Lerp(finalPitch, pitch, Time.deltaTime*lerpSpeed);
            finalRoll=Mathf.Lerp(finalRoll, roll, Time.deltaTime * lerpSpeed);
            finalYaw=Mathf.Lerp(finalYaw, yaw, Time.deltaTime * lerpSpeed);
            
            Quaternion rot = Quaternion.Euler(finalPitch,finalYaw, finalRoll);
            rb.MoveRotation(rot);
        }

    }
}
