using UnityEngine;

public class ConeDetection : MonoBehaviour
{
    [SerializeField] private Transform otherObject;
    void OnDrawGizmos() 
    {
	    Vector2 dirTowardsOtherObject = (otherObject.position - transform.position).normalized;
	    float dotProduct = Vector2.Dot(dirTowardsOtherObject, transform.right);
        if(dotProduct >= 0.4)
        {
            Debug.Log("ça marche");
        }
        else
        {
            Debug.Log("ça marche pas");
        }
    }
}
