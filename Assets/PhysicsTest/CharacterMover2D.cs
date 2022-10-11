using UnityEngine;

class CharacterMover2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpForce;
    [SerializeField] float moveForce;
    [SerializeField] float moveSpeed;
    [SerializeField] int airJumps = 1;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] LayerMask canJumpLayer;

    bool onGround = false;
    int jumpCounts = 0;

    void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();

        /* GetComponentInParent<Collider2D>();
        GetComponentInChildren<SpriteRenderer>(); */
    }

    void Update()
    {
        bool jumpPress = Input.GetKeyDown(KeyCode.Space);

        if (jumpPress && (onGround || jumpCounts > 0))
        {
            Vector2 v = rigidbody.velocity;
            v.y = 0;
            rigidbody.velocity = v;

            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpCounts--;
        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");

        if (onGround)
        {
            //A földön nincs tehetetlenségünk
            Vector2 v = rigidbody.velocity;
            v.x = x * moveSpeed;
            rigidbody.velocity = v;
        }

        else
        {
            // A levegõben tehetetlen mozgásunk van
            rigidbody.AddForce(Vector2.right * x * moveForce);

            // Maximalizáljuk a vízszintes sebességet
            Vector2 v = rigidbody.velocity;
            float direction = Mathf.Sign(v.x);
            float horizontalSpeed = Mathf.Abs(v.x);
            v.x = Mathf.Min(horizontalSpeed, moveSpeed) * direction;
            rigidbody.velocity = v;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        int layer = collision.gameObject.layer;

        if (groundLayer == (groundLayer | (1<<layer)))
        {
            onGround = true;

            // bool noJump = collision.gameObject.layer == "GroundNoJump";

            if ((canJumpLayer.value & layer) != 0)
            {
                jumpCounts = airJumps + 1;
            }
            // Debug.Log("Enter: " + collision.collider.name);
            else
            {
                jumpCounts = 0;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
        // Debug.Log("Exit: " + collision.collider.name);
    }

    /*
                Igen           Nem

    Egyszeri    Impulse        Velocity Change
    Folytonos   Force          Acceleration         } Fixed Update
     
     */
}
