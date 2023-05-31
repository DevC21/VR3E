using UnityEngine;
using UnityEngine.Events;

public class UI : MonoBehaviour
{
    public float destroyDelay = 1.0f;

    public UnityEvent OnCreated;
    public UnityEvent UI_Destoryed;

    private bool isDestroyed = false;

    private void Start()
    {
        OnCreated?.Invoke();
        UIManager.Instance.OnSpawned(this);
    }

    public void Destroy()
    {
        if (isDestroyed)
            return;
        isDestroyed = true;

        Destroy(gameObject, destroyDelay);

        UI_Destoryed?.Invoke();
        UIManager.Instance.OnDestroyed(this);
    }
}