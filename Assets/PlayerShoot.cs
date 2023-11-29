using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;

    public void Fire()
    {
        Instantiate(projectilePrefab , transform.position,  Quaternion.LookRotation(transform.position, Vector3.forward));
    }
}
