using UnityEngine;

class HelloWorld : MonoBehaviour
{
    void Start()
    {
        //Komment
        /*Ez is komment*/
        Debug.Log("Hello Kolos");
        Debug.Log("I'm " + name);

        int myFirstVariable;
        myFirstVariable = 56;

        myFirstVariable = 47;

        int a, b, c;

        a = 3;
        b = 7;
        c = a + b;
        Debug.Log(c);
        c = 11;
        Debug.Log(c);

        int d = a - b;
        int e = a * b;
        int f = a / b;

        Debug.Log(f);

        float myFirstFloat = 2.67f;
        float mySecondFloat = 4;
        float ratio = myFirstFloat / mySecondFloat;

        Debug.Log(ratio);

        string myFirstString = "Szeretlek, ";
        string mySecondString = "Lia baba";

        string sss = myFirstString + mySecondString;

        Debug.Log(sss);

        int m = 22 % 7; //1
        float mf = 12,34 % 5; //2.34f

        bool bbb1 = true;
        bool bbb2 = false;


    }
}