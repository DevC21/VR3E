using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;

    public static UIManager Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType<UIManager>();
            return instance;
        }
    }

    public UnityEvent<UI> OnSpawn, OnDestroy;

    private List<UI> uis = new List<UI>();

    private void Awake()
    {
        instance = this;
    }

    public void OnSpawned(UI ui)
    {
        uis.Add(ui);
        OnSpawn?.Invoke(ui);
    }

    public void OnDestroyed(UI ui)
    {
        if (uis.Remove(ui))
        {
            OnDestroy?.Invoke(ui);
        }
    }

    public void DestoryAll()
    {
        while (uis.Count > 0)
        {
            uis[0]?.Destroy();
        }
    } 
}
