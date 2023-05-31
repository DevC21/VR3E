using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDestroy : MonoBehaviour
{
    [SerializeField]
    string UI_Name;

    GameObject UI;

    public void Call()
    {
        UI = GameObject.Find($"{UI_Name}(Clone)");

        DestroyImmediate(UI, true);
    }
}