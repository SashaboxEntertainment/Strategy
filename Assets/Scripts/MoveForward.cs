using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : IStrategy
{
    public void Perform(Transform transform)
        => transform.position += Vector3.forward * Time.deltaTime;
}
