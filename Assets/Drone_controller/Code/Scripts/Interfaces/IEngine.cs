using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myinputs
{
    public interface IEngine
    {
        void InitEngine();

        void UpdateEngine(Rigidbody rb,Drone_inputs input);
    }
}