using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myinputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class Base_Rigidbody : MonoBehaviour
    {
        [Header("Rigidbody Properties")]
        [SerializeField]private float weightInLbs = 1f;
        const float lbs2kg = 0.454f;
        protected float startDrag;
        protected float startAngularDrag;
        protected Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            if (rb)
            {
                rb.mass = weightInLbs * lbs2kg;
                startDrag = rb.drag;
                startAngularDrag = rb.angularDrag;
            }
        }

        // FixedUpdate�����ĵ���Ƶ���ǹ̶���
        void FixedUpdate()
        {
            if (!rb)
            {
                return;
            }
            HandlePhysics();
        }

        protected virtual void HandlePhysics() { }
    }

}
