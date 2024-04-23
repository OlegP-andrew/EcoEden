using UnityEngine;

public class PlayerRespawner : MonoBehaviour
{
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    public void RespawnPlayer(Vector3 position)
    {
        transform.position = position;
    }
}
