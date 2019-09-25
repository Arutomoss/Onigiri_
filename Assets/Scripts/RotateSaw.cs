using UnityEngine;

public class RotateSaw : MonoBehaviour
{
    public float rotateSpeed = 5;
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * rotateSpeed);
    }
}
