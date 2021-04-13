using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform player;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 3)
        {
            timer += Time.deltaTime;
        }else if(timer >= 3)
        {
            timer = 0; 
            Instantiate(enemy, new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(4, -4)) + player.position, Quaternion.Euler(0, 0, 0), null);
        }

    }
    
}