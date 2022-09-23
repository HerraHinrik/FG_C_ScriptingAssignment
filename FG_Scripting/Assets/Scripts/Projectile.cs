using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private float weaponDamage;
    public void Initialize()
    {
        projectileBody.AddForce(transform.forward * 350f + transform.up * 5f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerHealth>)
        if (PlayerHealth != null)
        {
            PlayerHealth.TakeDamage(weaponDamage);
        }

        
        Destroy(this.gameObject);
    }
    
}


