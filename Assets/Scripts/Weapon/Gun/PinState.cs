using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinState : MonoBehaviour
{
    GameObject FireExtingusher;
    private Shooter shooter;

    private void Awake()
    {
        FireExtingusher = GameObject.Find("FireExtingusher");
        shooter = FireExtingusher.GetComponent<Shooter>();
    }

    public void StateChange()
    {
        shooter.pinstate = true;
    }
}
