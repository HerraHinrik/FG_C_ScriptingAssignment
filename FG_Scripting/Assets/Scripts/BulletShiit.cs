using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShiit : MonoBehaviour
{
    [SerializeField] private Rigidbody theBullit;
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) ;
        {
            clone = Instantiate(theBullit, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.(0, 0, speed));
            
            Destroy(clone.gameObject);
        }

    }
}
