using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    [SerializeField]
    private GameObject cloud;
    private Vector3 cloud_tr;

    private void Start()
    {
        cloud_tr = cloud.transform.localScale;
        StartCoroutine(Spawn());
    }

    // void Update()
    // {
    //     if (transform.position.x > 13f)
    //     {
    //         Destroy(cloud);
    //     }
    // }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(14f, 25f));
            cloud.transform.localScale = cloud_tr;
            cloud.transform.localScale -= new Vector3(Random.Range(0.05f, 0.2f), Random.Range(0.05f, 0.2f), 0);
            Instantiate(cloud, new Vector2(-12f, Random.Range(2.5f, 5f)), Quaternion.identity);
        }
    }
}
