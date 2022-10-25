using System.Collections.Generic;
using UnityEngine;

class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] intArrayField;
    [SerializeField] string[] stringArrayField;

    [SerializeField] List<int> intList;

    void OnValidate()
    {
        intList.Clear();
        for (int i = 0; i < 25; i++)
        {
            intList.Add(Random.Range(0, 101));
        }
        intList.Sort();
    }
    void Start()
    {
        int[] arrayOfInts = new int[5];

        for (int i = 0; i < arrayOfInts.Length; i++)
        {

            arrayOfInts[i] = i + 1;
            // int element = arrayOfInts[i];
            // Debug.Log(element);
        }

        int summa = 0;
        // for (int i = 0; i < arrayOfInts.Length; i++)

        // summa += arrayOfInts[i];

        foreach (int element in arrayOfInts)
        {
            summa += element;
        }

        Debug.Log(summa); //15

        string[] stringArray = { "AAA", "BBB", "CCC" };
        stringArray[1] = "DDD";

        List<int> intList = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            intList.Add(i + 1);
        }

        intList.RemoveAt(3);
        intList.Remove(1);

        summa = 0;
        for (int i = 0; i < intList.Count; i++)
        {
            summa = intList[i];
        }

        Debug.Log(summa);

        List<string> stringList = new List<string>();
        stringList.Add("XXXX");

        bool contains = stringList.Contains("YYY");

        if (contains)
            Debug.Log("CONTAINS");
        else
            Debug.Log("NOT CONTAINS");

        int index = stringList.IndexOf("XXXX");
        stringList.Clear();
    }

    void Update()
    {
        
    }
}
