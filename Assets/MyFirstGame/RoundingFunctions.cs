using UnityEngine;

class RoundingFunctions : MonoBehaviour
{
   [SerializeField] float num;

   [SerializeField] float rounded;
   [SerializeField] float roundedUp;
   [SerializeField] float roundedDown;

    // Update is called once per frame
    void OnValidate()
    {
        rounded = Round (num) ;
        roundedUp = Ceil (num);
        roundedDown = Floor (num);

    }

    float Floor (float n)
    {
        float remainder = n % 1;
        return n - remainder;
    }
    float Ceil (float n)
    {
        float remainder = n % 1;

        if (remainder == 0)
            return n;

        return n + (1 - remainder);
    }

    float Round (float n)
    {
        float remainder = n % 1;

        if (remainder < 0.5)
            return Floor(n);
        else
            return Ceil(n);
    }
}
