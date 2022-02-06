using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStrategy
{
    void Perform(Transform transform);
}
