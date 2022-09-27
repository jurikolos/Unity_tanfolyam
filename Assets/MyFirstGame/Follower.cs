using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] Transform target;
    void Update()
    {
        Vector3 targetPoint = target.position;
        Vector3 pos = transform.position;
        /*
        Vector3 velocity = targetPoint - pos;
        velocity.Normalize();
        velocity *= speed;
        velocity *= Time.deltaTime;
        float stepDistance = velocity.magnitude;
        float targetDistance = Vector3.Distance(targetPoint, pos);
        if (targetDistance < stepDistance)
        {
            velocity.Normalize();
            velocity *= targetDistance;
        }

        transform.position += velocity;
        */
        float maxStep = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(pos, targetPoint, maxStep);

        if (targetPoint != pos)
        {
        transform.rotation = Quaternion.LookRotation(targetPoint - pos);
        }
}
}
