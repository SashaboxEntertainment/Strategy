using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Performer : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy) =>
        _strategy = strategy;

    private void Update() =>
        _strategy.Perform(_playerTransform);
}
