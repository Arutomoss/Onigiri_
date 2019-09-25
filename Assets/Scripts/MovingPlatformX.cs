using UnityEngine;

public class MovingPlatformX : MonoBehaviour
{
    public float speed;
    public float leftPoint, rightPoint;

    private void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (transform.position.x >= leftPoint)
        {
            speed = -speed;
        }
        else if (transform.position.x <= rightPoint)
        {
            speed = -speed;
        }
    }
}
