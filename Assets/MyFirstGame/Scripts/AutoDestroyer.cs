using UnityEngine;

class AutoDestroyer : MonoBehaviour
{
    [SerializeField] float destructionTime;
    [SerializeField] GameObject go;
    [SerializeField] MonoBehaviour mb;

    float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    void Test()
    {
        go.SetActive(true);
        go.SetActive(false);

        enabled = false;
        enabled = true;

        mb.enabled = true;
        mb.enabled = false;
    }

    void Update()
    {
        float currenttime = Time.time;

        if (startTime + destructionTime < currenttime)
        {
            Destroy(gameObject);
        }
    }

    void Awake()
    {
        Debug.Log("Bullet Awaken");
    }

    void OnDestroy()
    {
        Debug.Log("Bullet Destroyed");
    }

    void OnEnable()
    {
        Debug.Log("Bullet Enabled");
    }

    void OnDisable()
    {
        Debug.Log("Bullet Disabled");
    }
}
