using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    public float speed;
    public GameObject leftPoint, rightPoint;

    private void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (transform.position.x > leftPoint.transform.position.x)
        {
            speed = -speed;
        }
        else if (transform.position.x < rightPoint.transform.position.x)
        {
            speed = -speed;
        }
    }
}
