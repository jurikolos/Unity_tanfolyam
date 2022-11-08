using System.Collections.Generic;
using UnityEngine;

class Shooter : MonoBehaviour
{
    enum ShootingPattern
    {
        Random, Sequence, Keyboard
    }

    [SerializeField] GameObject [] projectilePrototypes;
    [SerializeField] List <KeyCode> keys;
    [SerializeField] float speed;

    [SerializeField] ShootingPattern pattern;

    int count = 0;
    int bulletIndex = 0;
    void Update()
    {
        BulletSelect();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void BulletSelect()
    {
        for (int i = 0; i < keys.Count; i++)
        {
            KeyCode kc = keys[i];
            if (Input.GetKeyDown(kc))
            {
                bulletIndex = i;
            }
        }
    }

    void Shoot()
    {
        GameObject proto;

        if (pattern == ShootingPattern.Random)
        {
            int randomNum = Random.Range(0, projectilePrototypes.Length);

            proto = projectilePrototypes[randomNum];
        }

        else if (pattern == ShootingPattern.Sequence)
        {
            int index = count % projectilePrototypes.Length;
            proto = projectilePrototypes[index];
        }

        else
        {
            int safeIndex = Mathf.Clamp(bulletIndex, 0, projectilePrototypes.Length - 1);
            proto = projectilePrototypes[safeIndex];
        }

        GameObject projectile = Instantiate(proto);

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
