using UnityEngine;
using UnityEngine.Events;

public class Mob : MonoBehaviour
{
    public float destroyDelay = 1.0f;
    public UnityEvent OnCreated;
    public UnityEvent OnDestoryed;
    GameObject chid;
    Color color;
    float size;
    int count = 0;
    private bool isDestroyed = false;
    
    
    private void Start()
    {
        
        OnCreated?.Invoke();
        MobManager.Instance.OnSpawned(this);
    }

    public void Destroy()
    {
        if (isDestroyed)
            return;
        if(count < 10)
        {
            fireHpDown(this);
            count += 1;
        }
        else
        {
            isDestroyed = true;
            Destroy(gameObject, destroyDelay);

            OnDestoryed?.Invoke();
            MobManager.Instance.OnDestroyed(this);
        }
    }
    public void fireHpDown(Mob mob)
    {
        chid = mob.transform.GetChild(0).gameObject;
        size = chid.GetComponent<ParticleSystem>().startSize;
        size = size - 0.5f;
        chid.GetComponent<ParticleSystem>().startSize = size;
    }
}