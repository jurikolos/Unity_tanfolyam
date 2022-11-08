using UnityEngine;

class PathMover : MonoBehaviour
{
    [SerializeField] Vector3 a, b;
    [SerializeField] Color col;
    [SerializeField] float speed;

    bool toA = false;

    void OnValidate()
    {
        transform.position = (a + b) / 2;
    }

    void Update()
    {

        Vector3 target = b;
        if (toA)
            target = a;
        else
            target = b;

        if(target == transform.position)
        {
            toA = !toA;
        }

        transform.position = Vector3.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(a, 0.2f);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(b, 0.2f);
        Gizmos.color = new Color (1,0,1,1);
        Gizmos.DrawLine(a, b);
    }
}
