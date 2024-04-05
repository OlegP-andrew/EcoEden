using UnityEngine;

public class PlayerRespawner : MonoBehaviour
{
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        //TODO: condition to respawn player
    }

    public void RespawnPlayer()
    {
        transform.position = initialPosition;
    }
}
