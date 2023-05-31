using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkAnim : MonoBehaviour
{
    float time;

    private Renderer target;

    private void Awake()
    {
        target = GetComponent<Renderer>();
    }

    void Update()
    {
        if (time < 0.5f)
        {
            target.material.SetColor("_Color", new Color(255, 0, 0, 0.6f - time));
        }
        else
        {
            target.material.SetColor("_Color", new Color(255, 0, 0, time - 0.4f));
            if (time > 1f)
            {
                time = 0;
            }
        }
        time += Time.deltaTime;
    }
}
