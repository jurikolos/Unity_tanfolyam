using TMPro;
using UnityEngine;

class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    int collectedValue;

    void Start()
    {
        FreshTest();
    }
    void OnTriggerEnter(Collider other)
    {

        Collectable collectable = other.GetComponent<Collectable>();

        if (collectable != null)
        {
            collectedValue += collectable.value;
            collectable.TeleportRandom();
            FreshTest();
        }
    }

    void FreshTest()
    {
        if (scoreText != null)
            scoreText.text = $"Score: {collectedValue}";
    }
}
