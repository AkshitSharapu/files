using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;     // Reference to the player
    public Vector3 offset;       // Distance between camera and player
    public float smoothSpeed = 5f; // Smoothness of camera movement

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}
