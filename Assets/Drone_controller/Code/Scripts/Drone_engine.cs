using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myinputs
{
    [RequireComponent(typeof(BoxCollider))]
    public class Drone_engine : MonoBehaviour,IEngine
    {
        [Header("Engine proporties")]
        [SerializeField] private float maxPower = 3f;
        private float finalInput;

        [Header("Properller Properties")]
        [SerializeField] private Transform properller;
        private float propRotSpeed=500f;
        public void InitEngine()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEngine(Rigidbody rb,Drone_inputs input)
        {
            Vector3 engineForce = Vector3.zero;
            finalInput = Mathf.Lerp(finalInput, input.Throttle * maxPower, Time.deltaTime);
            engineForce = transform.up * ((rb.mass * Physics.gravity.magnitude) + input.Throttle * maxPower) /4f;
            rb.AddForce(engineForce, ForceMode.Force);
            //Debug.Log("running engine:" + gameObject.name);
            Debug.Log(Time.deltaTime);
            HandlePropellers();

        }

        void HandlePropellers()
        {
            if (!properller) return;
            properller.Rotate(Vector3.up, propRotSpeed);
        }
    }
}
