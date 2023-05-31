using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCanvasMainCamera : MonoBehaviour
{

    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = gameObject.GetComponent<Canvas>();
    }

    private void Update()
    {
        var Position = Camera.main.transform.position;
        var Rotation = Camera.main.transform.rotation;

        canvas.transform.SetPositionAndRotation(Position + (Camera.main.transform.forward * 0.5f), Rotation);
    }
}
