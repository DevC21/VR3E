using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndingTrigger : MonoBehaviour
{
    [SerializeField]
    float TeleportTime = 4.0f;

    public UnityEvent OnTrigger;

    Collider other;

    private void OnTriggerEnter(Collider other)
    {
        this.other = other;
        Debug.Log($"Trigger @ {other.gameObject.name} !");
        OnTrigger?.Invoke();
        Invoke("Call", TeleportTime);
    }


    private void Call()
    {
        other.gameObject.transform.SetPositionAndRotation(new Vector3(-33.638f, 1.365f, -29.62f), new Quaternion(0f, 90f, 0f, 0f));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
