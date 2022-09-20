using UnityEngine;

class MathFunctions : MonoBehaviour
{
    float Abs(float num)
    {
        if (num >= 0)
        {
            return num;
        }
        else
        {
            return -num;
        }
    }
}
