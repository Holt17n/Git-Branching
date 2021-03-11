using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float moveSpeed;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        // This destroys the bullet after 4 seconds
        Destroy(bullet, 4);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //Check collision name
        Debug.Log("collision name = " + col.gameObject.name);
        if (col.gameObject.name == "EnemyCube")
        {
        }
        else if (col.gameObject.name == "EnemyTurret")
        {
        }
        else
        {
            Destroy(bullet);
        }
    }
    // Update is called once per frame
    void Update()
    {
        // moves the bullet forward
        transform.Translate(Vector3.right * moveSpeed* Time.deltaTime);
    }
}
