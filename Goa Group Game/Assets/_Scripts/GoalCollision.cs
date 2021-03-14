using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalCollision : MonoBehaviour
{
    private GameObject[] currentLevel;
    public GameObject self;
    public GameObject victory;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentLevel = GameObject.FindGameObjectsWithTag("CurrentLevel");
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            if (currentLevel[0].name == "Level1")
            {
                SceneManager.LoadScene("LevelTwo");
            }
            if (currentLevel[0].name == "Level2")
            {
                SceneManager.LoadScene("LevelThree");
            }
            if (currentLevel[0].name == "Level3")
            {
                SceneManager.LoadScene("VictoryScreen");
            }
        }
    }
}
