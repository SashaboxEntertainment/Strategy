using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonComponent : MonoBehaviour
{
    [SerializeField] private Performer _performer;
    [SerializeField] private Button _button;

    private void Awake()
    {
        _button.onClick.RemoveAllListeners();
        _button.onClick.AddListener(() =>
        {
            //_performer.SetStrategy();
        });
    }

    public void RunStrategy()
    {
        //_performer.SetStrategy();
    }
}
