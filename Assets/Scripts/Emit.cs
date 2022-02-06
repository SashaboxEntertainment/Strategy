using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emit : IStrategy
{
    public void Perform(Transform transform)
        => transform.GetComponent<ParticleSystem>();
}
