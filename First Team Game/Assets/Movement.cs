using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement: MonoBehaviour
{
    public float DashSpeed;
    public Rigidbody2D rb;
    public float NormalSpeed;
    public int damage;
    public Collider2D cdr;
    public LayerMask enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cdr.enabled = false;
            Ray ray = new Ray(transform.position, transform.up);
            RaycastHit2D[] hit = Physics2D.RaycastAll(ray.origin, ray.direction, DashSpeed, enemy);
            foreach(RaycastHit2D Thing in hit)
            {
                health eHealth = Thing.collider.gameObject.GetComponent<health>();
                if(eHealth != null)
                {
                    eHealth.TakeDamage(damage);
                }
            }
            rb.MovePosition(rb.position + (DashSpeed * (Vector2)transform.up));
            cdr.enabled = true;
        }
        else
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * NormalSpeed * Time.deltaTime, Input.GetAxis("Vertical") * NormalSpeed * Time.deltaTime);
        }
    }
    
}
