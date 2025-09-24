using UnityEngine;

public class LightFollow : MonoBehaviour
{
    public Transform player;     // Reference to the player
    public Vector3 offset;       // Distance between light and player

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
