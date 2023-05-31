using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Hittable : MonoBehaviour
{
    public UnityEvent OnHit;
    
    public void Hit()
    {
       
        OnHit?.Invoke();
    }
}