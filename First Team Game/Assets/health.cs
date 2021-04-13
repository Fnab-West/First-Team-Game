using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public bool dead = false;
    public GameObject deatheffect = GameObject.Find("effect").GetComponent<chosenEffect>().chosen;
    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
    }
    void Die()
    {
        dead = true;
        GameObject effect = Instantiate(deatheffect, transform, false);
        effect.transform.localPosition = new Vector3(0, -1);
        ParticleSystem system = effect.GetComponent<ParticleSystem>();
        system.Play();
        Destroy(gameObject, system.main.duration);
    }
    public void SetHealth(int amount)
    {
        Health = amount;
        if (Health <= 0)
        {
            Die();
        }
    }
    public void TakeDamage(int amount)
    {
        Health -= amount;
        if(Health <= 0)
        {
            Die();
        }
    }
    public void AddHealth(int amount)
    {
        Health += amount;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
