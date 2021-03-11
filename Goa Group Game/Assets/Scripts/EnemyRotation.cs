using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    public float rotation;
    private bool rotating;
    public GameObject player;
    public GameObject bullet;
    public Transform LaserHit;
    public GameObject turret;
    public int layerMask = 9;
    public int delay;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(self);
        }
    }
            void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(turret.transform.position, transform.right, layerMask);
        if (hit.collider != null)
        {
            delay += 1;
            if (hit.collider.name == "PlayerCube" && delay >= 20)
            {
                Debug.Log("HEYYYYOOOOOOO!");
                Instantiate(bullet, player.transform.position, player.transform.rotation);
                delay = 0;
            }

        }
        player.transform.Rotate(0, 0, (rotation * Time.deltaTime));
    }
}
