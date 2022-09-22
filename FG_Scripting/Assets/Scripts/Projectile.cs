using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private GameObject damageIndicatorPrefab;
    private bool isActive;
    public void Initialize()
    {
        isActive = true;
        Instantiate(projectileBody,)
       // projectileBody.AddRelativeForce(0,0,500f);
        // projectileBody.AddForce(transform.forward * 500f + transform.up * 5f + transform.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject damageIndicator = Instantiate(damageIndicatorPrefab);
        damageIndicator.transform.position = collision.GetContact(0).point;
    }
}


