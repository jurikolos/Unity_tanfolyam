using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed = 180;

    void Update()
    {
        // Inputkezelés

        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);

        float x = 0;
        if (right && !left)
            x = 1;
        else if (left && !right)
            x = -1;

        float y = 0;
        if (up && !down)
            y = 1;
        else if (down && !up)
            y = -1;

        Vector3 velocity = new Vector3(x, 0, y);
        velocity.Normalize();
        velocity *= speed;

        // Elmozdulás
        /*Vector3 position = transform.position;
        position += velocity * Time.deltaTime;
        transform.position = position; */

        transform.position += velocity * Time.deltaTime;

        if (velocity != Vector3.zero)
        {
            Quaternion targetRot = Quaternion.LookRotation(velocity);

            transform.rotation = 
                Quaternion.RotateTowards(transform.rotation, targetRot, angularSpeed * Time.deltaTime);
        }
    }
}
