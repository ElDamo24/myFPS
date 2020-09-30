using UnityEngine;

public class playerScript : MonoBehaviour
{
    public CharacterController controller;
    public Transform isGrounded;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float speedMovement = 12f;
    public float jumpHeight = 3f;

    Vector3 velocity;
    private float gravity = -19.62f;
    private bool isPlayerGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isPlayerGrounded = Physics.CheckSphere(isGrounded.position, groundDistance, groundMask);

        if (isPlayerGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speedMovement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isPlayerGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
