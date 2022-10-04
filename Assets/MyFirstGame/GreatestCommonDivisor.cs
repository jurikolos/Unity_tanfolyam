using UnityEngine;

public class GreatestCommonDivisor : MonoBehaviour
{
    int GCD ( int a, int b)
    
    {
        int min = Mathf.Min(a, b);
        int greatest = 0;
        for (int i = 1; i <= min; i++)
        {
            if (a % i == 0 && b % i == 0)
                greatest = i;
        }

        return greatest;
    }

    
    void Update()
    {
        
    }
}
