using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction; 
    // InputAction rotateAction;

    private Vector2 direction;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 700f;
    [SerializeField] float smooth = 5f;

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
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(0f, angle, 0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * smooth);

    }

    private void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.y, 0, -1 * direction.x) * speed * Time.deltaTime;
    }
}
