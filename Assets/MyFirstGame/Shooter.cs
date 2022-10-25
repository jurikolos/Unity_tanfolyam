using UnityEngine;

class Shooter : MonoBehaviour
{
    enum ShootingPattern
    {
        Random, Sequence, Keyboard
    }

    [SerializeField] GameObject [] projectilePrototypes;
    [SerializeField] KeyCode [] keys;
    [SerializeField] float speed;

    [SerializeField] ShootingPattern pattern;

    int count = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject proto;

            if (pattern == ShootingPattern.Random)
            {
                int randomNum = Random.Range(0, projectilePrototypes.Length);

                proto = projectilePrototypes[randomNum];
            }

            else
            {
                int index = count % projectilePrototypes.Length;
                proto = projectilePrototypes[index];
            }

            GameObject projectile = Instantiate (proto);

            projectile.transform.position = transform.position;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            Vector3 direction = transform.forward;
            direction.Normalize();

            /*
            Vector3 v = transform.TransformVector(Vector3.up);
            Vector3 v2 = transform.InverseTransformVector(v);
            */

            rb.velocity = direction * speed;

            count++;
        }
    }
}
