using UnityEngine;

class MethodPractice : MonoBehaviour
{
    [SerializeField] float n1, n2, n3;
    [Space]
    [SerializeField] float max;

    void OnValidate()
    {
        max = Maximum(n1, n2, n3);
    }
    void Start()
    {
        LogSqr(1, 5);
        LogSqr(10, 20);
        LogSqr(3, 7);
    }

    void LogSqr(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Debug.Log(i * i);
        }
    }

    float Power(float baseNumber, int exponent)
    {
        float number = 1;

        for (int i = 0; i < exponent; i++)
        {
            number = number * baseNumber;
        }
        return number;
    }

    float Minimum (float a, float b)
    {
        if (a <= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    float Maximum (float a, float b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    float Maximum (float a, float b, float c)

    {

        if (a >= b && a >= c)
        {
            return a;
        }
        else if (b>=c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }

    /*float Round (float num)
    {

    }*/
}
