using System;
using System.Collections;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    public float topPoint, bottomPoint;

    private float currentSpeed;

    private void Start()
    {
        currentSpeed = speed;
    }

    private void Update()
    {
        transform.Translate(0, currentSpeed * Time.deltaTime, 0);

        if (transform.position.y >= topPoint)
        {
            currentSpeed = -speed;
        }
        else if(transform.position.y <= bottomPoint)
        {
            currentSpeed = speed;
        }
    }
}
