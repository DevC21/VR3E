using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClickObject : MonoBehaviour
{
    [SerializeField]
    string ClickName;

    GameObject Click;

    private void Awake()
    {
        Click = GameObject.Find("Game Play").transform.Find($"{ClickName}").gameObject;
    }

    public void Active()
    {
        Click.SetActive(true);
    }
}
