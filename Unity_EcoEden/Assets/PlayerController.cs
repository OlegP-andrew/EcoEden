using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction; 
    InputAction rotateAction;

    [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 700f;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
        rotateAction = playerInput.actions.FindAction("Rotate");
    }

    private void Update()
    {
        MovePlayer();
        // RotatePlayer();
    }

    private void RotatePlayer()
    {
        Vector2 direction = rotateAction.ReadValue<Vector2>();
        Quaternion toRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.y), Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    }

    private void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * speed * Time.deltaTime;
    }
}
