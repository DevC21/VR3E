using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndingVoiceTrigger : MonoBehaviour
{
    [SerializeField]
    float PlayDelayTime = 2.0f;
    [SerializeField]
    AudioSource audioSource;


    Collider other;

    private void OnTriggerEnter(Collider other)
    {
        this.other = other;
        Debug.Log($"Trigger @ {other.gameObject.name}!");
        audioSource.PlayDelayed(PlayDelayTime);
    }
}
