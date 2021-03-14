using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBullet : MonoBehaviour
{
    public float moveSpeed;
    public GameObject bullet;
    private GameObject[] currentLevel;

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
        if (col.gameObject.tag == "Enemy")
        {
        }
        else if (col.gameObject.name == "EnemyTurret")
        {
        }
        else if (col.gameObject.tag == "Player")
        {
            currentLevel = GameObject.FindGameObjectsWithTag("CurrentLevel");
            if (currentLevel[0].name == "Level1")
            {
                SceneManager.LoadScene("LevelOne");
            }
            if (currentLevel[0].name == "Level2")
                {
                    SceneManager.LoadScene("LevelTwo");
                }
            if (currentLevel[0].name == "Level3" )
            {
                SceneManager.LoadScene("LevelThree");
            }
            
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
