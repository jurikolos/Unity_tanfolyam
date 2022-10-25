using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] Transform target;
    [SerializeField] AnimationCurve speedOverDistance;

    [SerializeField] new Rigidbody rigidbody;

    private void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody>();
    }

    //[SerializeField, FormerlySerializedAs("")]
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

        float distance = Vector3.Distance(transform.position, target.position);
        float speed = speedOverDistance.Evaluate(distance);

        /*
        float maxStep = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(pos, targetPoint, maxStep);
        */

        Vector3 direction = targetPoint - pos;
        direction.Normalize();

        rigidbody.velocity = direction * speed;

        if (targetPoint != pos)
        {
        transform.rotation = Quaternion.LookRotation(targetPoint - pos);
        }
    }
}
