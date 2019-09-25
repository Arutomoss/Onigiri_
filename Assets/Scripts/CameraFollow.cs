using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smothedPosition = Vector3.Lerp(transform.position, desiredPosition, smothSpeed);
        transform.position = smothedPosition;
    }
}