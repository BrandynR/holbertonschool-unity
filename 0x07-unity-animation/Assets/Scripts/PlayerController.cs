using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// This script moves the character controller forward
// and sideways based on the arrow keys.
// It also jumps when pressing space.
// Make sure to attach a character controller to the same game object.
// It is recommended that you make only one call to Move or SimpleMove per frame.

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private bool isCoroutine = true;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Animator anim;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                anim.SetTrigger("Jump");
                moveDirection.y = jumpSpeed;
            }

            if (moveDirection.magnitude >= 0.1f)
            {
                anim.SetBool("isRunning", true);
                float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
                characterController.Move(moveDirection * speed * Time.deltaTime);
            }
            else
                anim.SetBool("isRunning", false);
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Falling"))
            {
                anim.SetTrigger("isFalling");
                Debug.Log("Falling");
            }

        
        if (other.CompareTag("Respawn"))
            StartCoroutine(LoadScene(1f));
    }
    IEnumerator LoadScene(float seconds)
    {
        isCoroutine = false;
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("Level01");
        isCoroutine = true;
    }
}
