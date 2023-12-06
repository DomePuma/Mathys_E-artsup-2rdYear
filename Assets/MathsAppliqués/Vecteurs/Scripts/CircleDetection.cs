using UnityEngine;

public class CircleDetection : MonoBehaviour
{
    [SerializeField] [Range(0,10)] private float circleSize;
    [SerializeField] CircleDetection circleDetection;
    public float CircleSize => circleSize; 
    private void OnDrawGizmos() 
    {
        
        if(DistanceVector(transform.position,circleDetection.transform.position) <= (circleSize + circleDetection.CircleSize)*(circleSize + circleDetection.CircleSize) )
        {
            Gizmos.color = Color.green;
        }
        Gizmos.DrawSphere(transform.position, circleSize);
    }
    private float DistanceVector(Vector2 circle, Vector2 point)
    {
        float num = circle.x - point.x;
        float num2 = circle.y - point.y;
        return num * num + num2 * num2;
    }
}


//Longueur de la distance centre du cercle -> point est plus petite ou égale au rayon du cercle alors le point est dans le cercle