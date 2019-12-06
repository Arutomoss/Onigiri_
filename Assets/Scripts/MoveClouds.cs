using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClouds : MonoBehaviour
{
    private float speed = 0.1f;

    private void FixedUpdate() {
        transform.Translate(speed * Time.deltaTime, 0, 0);  
    }

    // void FixedUpdate()
    // {
    //     transform.Translate(speed * Time.deltaTime, 0, 0);

    //     if (transform.position.x > 13f)
    //     {
    //         Destroy(this.gameObject);
    //     }   
    // }
}
