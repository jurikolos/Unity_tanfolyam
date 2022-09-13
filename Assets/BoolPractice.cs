using UnityEngine;

class BoolPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool b1 = true;
        bool b2 = false;
        Debug.Log(b1);

        b1 = false;

        Debug.Log(b1);

        int i1 = 3;
        int i2 = 7;

        bool b3 = i1 > i2;
        Debug.Log("i1 > i2:" + b3); //false

        i1 = 7;
        Debug.Log("i1 > i2:" + (i1 > i2)); //false

        Debug.Log("i1 >= i2:" + (i1 >= i2)); //true

        bool b6 = i1 == 6; //false
        bool b7 = i2 != 7; //false

        string s1 = "frgs";
        bool b8 = s1 == "efer"; //false

        bool b9 = s1 != "efer"; //false

        bool b10 = b6 == b9; //false

        // Logikai muveletek
        // AND &&
        bool b11 = b1 && b2; //false

        // OR || (Alt gr W)
        bool b12 = b1 || b2; //true

        // XOR ^ (KIZARO VAGY)
        bool b13 = b1 ^ b2;

        // NOT
        bool b14 = !b1;

    }

    // Update is called once per frame
   
}
