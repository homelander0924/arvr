using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 newPostion = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed * Time.deltaTime;
        rb.MovePosition(transform.position + newPostion);
    }
}

// Steps:
// 1. 3D Plane and Cube
// 2. Create Materials for Plane and Cube
// 3. Add ParticleSystem via Effects
// 4. ParticleSystem - Color over Lifetime
// 5. Add CineMachine from Package Manager
// 6. FreeLokkCamera via CineMachine
// 7. Connect Cube to Follow & LookAt of Cinemachine
// 8. Add RigidBody and (this) Script  to Cube.
// Done
