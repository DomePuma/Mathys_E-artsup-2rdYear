using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float projectileSpeed = 10;
    [SerializeField] private float destroyDelay = 3.0f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * (projectileSpeed * Time.fixedDeltaTime));
        
        Destroy(gameObject, destroyDelay);
    }
}