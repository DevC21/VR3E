using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UIChange : MonoBehaviour
{

    [SerializeField]
    float time = 0.0f;

    [SerializeField]
    GameObject prefab;

    GameObject parent;

    public void Awake()
    {
        parent = GameObject.Find("Text");
    }

    public void Call()
    {
        Invoke("SpawnToParent", time);
    }

    public void SpawnToParent()
    {
        Instantiate(prefab, transform.position, transform.rotation, parent.transform);
    }

    public void Spawn()
    {
        if (GameObject.Find($"{prefab.name}(Clone)") == null)
            Instantiate(prefab);
    }

    public void DelaySpawn()
    {
        Invoke("Spawn", time);
    }
}