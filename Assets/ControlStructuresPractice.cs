using UnityEngine;

class ControlStructuresPractice : MonoBehaviour
{

    /* Sequence (Egyenes)
       Selection (Elagazas)
       Loop (Ciklus) */

    [SerializeField] int number;
    [SerializeField] string pairity;
    [SerializeField] string positivity;

    void OnValidate ()
    {
        pairity = "";

        bool isEven = number % 2 == 0;
        if (isEven)
        {
            pairity = "PAROS";
        }
        else
        {
            pairity = "PARATLAN";
        }
        if (number < 0)
        {
            positivity = "NEGATIV";
        }
        else if (number > 0)
        {
            positivity = "POZITIV";
        }
        else
        {
            positivity = "NULLA";
        }
    }

    void Start()
    {
        int i = 1;
        while (i <= 10)

        {
            Debug.Log(i*i);
            i++;
        }

        for (int j = 0; j <= 9; j++)
        {
            Debug.Log(10-j);
        }

        // van olyan is hogy switch elagazas
    }
}
