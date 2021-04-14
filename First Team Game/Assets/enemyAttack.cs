using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public float radius;
    public LayerMask player;
    public float timer;
    public int Damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer< 3)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            Collider2D[] Hit =Physics2D.OverlapCircleAll((Vector2)transform.position, radius, player);
            foreach(Collider2D thing in Hit)
            {
                health thi = thing.gameObject.GetComponent<health>();
                if(thi != null)
                {
                    thi.TakeDamage(Damage);
                }
            }
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
