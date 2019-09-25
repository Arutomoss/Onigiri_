using UnityEngine;

public class Water : MonoBehaviour
{
    public float speed;
    public int direction = 1;

    void FixedUpdate()
    {
        transform.position += Vector3.left * Mathf.Sin(Time.time) * speed * direction;
    }
}
