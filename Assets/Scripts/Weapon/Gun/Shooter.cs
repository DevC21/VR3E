using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class Shooter : MonoBehaviour
{
    public LayerMask hittableMask;
    public GameObject hitEffectPrefab;
    public Transform shootPoint;

    public float ShootDelay = 0.1f;
    public float maxDistance = 100.0f;

    public UnityEvent<Vector3> OnShootSuccess;
    public UnityEvent OnShootFail;

    public bool pinstate = false;

    [SerializeField]
    AudioSource soundSFX;

    private void Awake()
    {

    }

    private void Start()
    {
        Stop();
    }

    public void Play()
    {
        StopAllCoroutines();
        StartCoroutine(Process());
    }

    public void Stop()
    {
        StopAllCoroutines();
        //soundStop
        soundSFX.Stop();
    }

    private IEnumerator Process()
    {
        var wfs = new WaitForSeconds(ShootDelay);

        while (true)
        {
            if (pinstate == true)
            {
                Shoot();
                //soundplay
                if (soundSFX.isPlaying == false)
                    soundSFX.Play();
            }
            yield return wfs;
        }
    }

    private void Shoot()
    {
            if (Physics.Raycast(shootPoint.position, shootPoint.forward, out RaycastHit hitInfo, maxDistance, hittableMask))
            {
                //Instantiate(hitEffectPrefab, hitInfo.point, Quaternion.identity);

                var HitObejct = hitInfo.transform.GetComponent<Hittable>();
                HitObejct?.Hit();

                OnShootSuccess?.Invoke(hitInfo.point);
            }
            else
            {
                var hitPoint = shootPoint.position + shootPoint.forward * maxDistance;
                OnShootSuccess?.Invoke(hitPoint);
            }
    }
}
