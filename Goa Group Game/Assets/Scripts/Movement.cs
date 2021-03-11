using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float rotation;
    public float moveSpeed;
    private bool rotating;
    public Rigidbody2D rb;
    public GameObject player;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // The following section contains basic movement for the player
        //Rotates player 
        if (rotating)
        {
            player.transform.Rotate(0, 0, (rotation * Time.deltaTime));
        }
        // Moves player if key is pressed
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotating = false;
            player.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
        // Stops rotation for next frame if key is lifted
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rotating = true;
        }


        // Following section creates a projectile upon pressing down the key
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Creates a bullet in the middle of the rocket
            Instantiate(bullet, player.transform.position, player.transform.rotation);
        }
    }
}
