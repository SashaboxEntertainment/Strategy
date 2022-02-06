using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : IStrategy
{
    public void Perform(Transform transform)
        => transform.Rotate(new Vector3(0, 0, 10 * Time.deltaTime));
}
