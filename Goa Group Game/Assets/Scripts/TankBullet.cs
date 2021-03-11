using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBullet : MonoBehaviour
{
    public float moveSpeed;
    public GameObject bullet;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        // This destroys the bullet after 4 seconds
        Destroy(bullet, 4);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //Check collision name
        if (col.gameObject.name == "PlayerCube")
        {
        }
        else if (col.gameObject.name == "Turret(was David)")
        {
        }
        else if (col.gameObject.name == "EnemyCube")
        {
            Destroy(enemy);
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
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
    }
}
