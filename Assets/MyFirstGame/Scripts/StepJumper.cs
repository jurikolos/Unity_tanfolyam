using UnityEngine;

public class StepJumper : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Vector3 target;

    void Start()
    {
        target = transform.position; 
    }

    void Update()
    {
        bool up = Input.GetKeyDown(KeyCode.UpArrow);
        bool down = Input.GetKeyDown(KeyCode.DownArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);

        if (up)
            target += Vector3.up;
        if (down)
            target += Vector3.down;
        if (right)
            target += Vector3.right;
        if (left)
            target += Vector3.left;

        transform.position =
            Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
