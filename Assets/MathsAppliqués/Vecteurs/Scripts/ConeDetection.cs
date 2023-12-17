using Unity.VisualScripting;
using UnityEngine;

public class ConeDetection : MonoBehaviour
{
    [SerializeField] private Transform otherObject;

    [SerializeField, Range(0,10)] private float radiusDetection; 
    
    private void OnDrawGizmos() 
    {
        Vector2 dirTowardsOtherObject = otherObject.position - transform.position;
        float dotProduct = Vector2.Dot(dirTowardsOtherObject, transform.right);
        
        if(dotProduct >= 0.4)
        {
            Debug.Log("ça marche || Dot Product");
        }
        else
        {
            Debug.Log("ça marche pas || Dot Product");
        }
	    
        Vector2 dirTowardsOtherObjectAngleMethod = otherObject.position - transform.position;
        
        if(dirTowardsOtherObjectAngleMethod.sqrMagnitude < radiusDetection * radiusDetection)
        {
            Debug.Log("ça marche || Angle");
        }
        else
        {
            Debug.Log("ça marche pas || Angle");
        }
    }
}
