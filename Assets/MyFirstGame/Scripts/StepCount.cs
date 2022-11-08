using UnityEngine;

class StepCount : MonoBehaviour
{
    [SerializeField] Vector2 a, b;
    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;

    // Update is called once per frame
    void Update()
    {
        stepCount = Mathf.CeilToInt(Vector2.Distance(a, b));
        step = (b - a) / stepCount;
    }
}
