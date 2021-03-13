using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLvlOne : MonoBehaviour
{
    private GameObject[] player;
    public GameObject prefabPlayer;
    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        Destroy(player[0]);
        Instantiate(prefabPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
