using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target;
    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("TrianglePlayer").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = (Vector2)target.position - (Vector2)transform.position;
        rb.velocity = speed * transform.up * Time.deltaTime;
    }
}
