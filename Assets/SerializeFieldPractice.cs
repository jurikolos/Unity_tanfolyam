using UnityEngine;

class SerializeFieldPractice : MonoBehaviour
{
    //  [ ]

    [SerializeField] int age;
    [SerializeField] float height;
    [SerializeField] string myName;
    [SerializeField] bool smoking;

    [SerializeField] int number1, number2;
    [SerializeField] int sum;
    [SerializeField] int difference;
    [SerializeField] int product;
    [SerializeField] float rate;

    // ctrl k + d: indentalas

    void Start()
    {
        int i;
        Debug.Log($"My name isÿ{myName}. I'm {age}");
        Debug.Log($"I'm {height}. Do I smoke? {smoking}");

    }

    void OnValidate()
    {
        sum = number1 + number2;
        difference = number1 - number2; //
        product = number1 * number2;
        rate = (float) number1 / number2;
    }
}
