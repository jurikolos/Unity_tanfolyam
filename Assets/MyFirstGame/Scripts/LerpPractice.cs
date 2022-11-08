using UnityEngine;

public class LerpPractice : MonoBehaviour
{
    [SerializeField] Color colorA, colorB;
    [SerializeField] Vector3 posA, posB;
    [SerializeField, Range (0,1)] float t;

    [SerializeField] Color lerpColor;
    [SerializeField] Vector3 lerpPos;
    void OnValidate ()
    {
        lerpColor = Color.Lerp(colorA, colorB, t);
        lerpPos = Vector3.Lerp(posA, posB, t);

        //lerpColor = Color.LerpUnclamped(colorA, colorB, t);
    }

    // Update is called once per frame
    void OnDrawGizmos()
    {
        Gizmos.color = colorA;
        Gizmos.DrawWireSphere(posA, 0.1f);
        Gizmos.color = colorB;
        Gizmos.DrawWireSphere(posB, 0.1f);
    }
}
