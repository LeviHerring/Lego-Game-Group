using UnityEngine;
using System.Collections;

public class gacksPlayerMovement: MonoBehaviour
{

    public float playerSpeed;
    public float walkSpeed = 10f;
    public float mouseSensitivity = 2f;
    public float jumpHeight = 3f;
    private bool isMoving = false;
    private bool isSprinting = false;
    private float yRot;

    private Animator anim;
    private Rigidbody rigidBody;

    [SerializeField] private float jumpForce = 10f;
    public Transform groundCheck;

    public bool isGrounded = true;

    // Use this for initialization
    void Start()
    {

        playerSpeed = walkSpeed;
        rigidBody = GetComponent<Rigidbody>();

        BoxCollider collider = GetComponent<BoxCollider>();
        isGrounded = true;

    }

    // Update is called once per frame
    void Update()
    {

        yRot += Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, yRot, transform.localEulerAngles.z);

        isMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * playerSpeed);
            rigidBody.velocity += transform.right * Input.GetAxisRaw("Horizontal") * playerSpeed;
            isMoving = true;
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * playerSpeed);
            rigidBody.velocity += transform.forward * Input.GetAxisRaw("Vertical") * playerSpeed;
            isMoving = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jumpForce, 1);
        }

        
    }
}