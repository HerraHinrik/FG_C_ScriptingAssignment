using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
     private float weaponDamage = 1.0f;
     [SerializeField] public float damageMulti;
    public void Initialize()
    {
        projectileBody.AddForce(transform.forward * 350f + transform.up * 5f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.gameObject.GetComponent<PlayerHealth>().TakeDamage(weaponDamage);
        }
        Destroy(this.gameObject);
    }
    
}


