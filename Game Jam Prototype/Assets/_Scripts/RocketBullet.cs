using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBullet : MonoBehaviour
{
    private float moveSpeed = 21f;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        // This destroys the bullet after 4 seconds
        Destroy(bullet, 4);
    }

    // Update is called once per frame
    void Update()
    {
        // moves the bullet forward
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
    }
}
