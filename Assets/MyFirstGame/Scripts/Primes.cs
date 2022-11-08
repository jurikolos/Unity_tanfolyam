using UnityEngine;

class Primes : MonoBehaviour
{

    private void Start()
    {
        WriteFirstPrimes(50);
    }
    void WriteFirstPrimes(int count)
    {
        int found = 0;

        for (int i = 2; found < count; i++)
        {
            bool isIPrime = IsPrime(i);
            if (isIPrime)
            {
                Debug.Log(i);
                found++;
            }
        }
    }

    bool IsPrime(int n)
    {
        for (int i = 2; i < n; i++)
        {
            bool devidable = n % i == 0;
            if (devidable)
                return false;
        }

        return true;
    }
}
