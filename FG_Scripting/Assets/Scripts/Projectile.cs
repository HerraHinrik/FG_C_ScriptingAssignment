using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private GameObject damageIndicatorPrefab;
    public void Initialize()
    {
        projectileBody.AddForce(transform.forward * 350f + transform.up * 5f);
        //projectileBody.AddForce(direction * 700f +transform.up * 300f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        GameObject damageIndicator = Instantiate(damageIndicatorPrefab);
        damageIndicator.transform.position = collision.GetContact(0).point;
    }
    
}


