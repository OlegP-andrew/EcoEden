using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction; 
    // InputAction rotateAction;

    public CharacterController controller;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public Transform cam;
    private float targetAngle;


    private Vector2 direction;
    [SerializeField] float speed = 5.0f;
    
    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
        // rotateAction = playerInput.actions.FindAction("Rotate");
    }

    private void Update()
    {
        direction = moveAction.ReadValue<Vector2>();
        if (direction.magnitude >= 0.1f)
        {
            RotatePlayer();
            MovePlayer();
        }
    }

    private void RotatePlayer()
    {
        targetAngle = Mathf.Atan2(-1 * direction.y, direction.x) * Mathf.Rad2Deg + cam.eulerAngles.y;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }

    private void MovePlayer()
    {
        Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        controller.Move(moveDir.normalized * speed * Time.deltaTime);
    }
}
