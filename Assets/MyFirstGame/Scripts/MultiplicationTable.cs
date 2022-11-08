using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Debug.Log($"{i} * {j} = {i * j}");
            }
        }
    }
}
