using UnityEditor.Search;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public float damage = 10f;
    [SerializeField] public float range = 100f;
    [SerializeField] private Camera currentCam;

   // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit
    }
}
