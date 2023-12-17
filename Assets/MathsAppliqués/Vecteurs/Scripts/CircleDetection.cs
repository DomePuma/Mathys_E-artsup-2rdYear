using UnityEngine;

public class CircleDetection : MonoBehaviour
{
    [SerializeField, Range(0,10)] private float _circleSize;
    [SerializeField] private CircleDetection _circleDetection;
    public float CircleSize => _circleSize; 
    
    private void OnDrawGizmos() 
    {
        if(DistanceVector(transform.position,_circleDetection.transform.position) <= (_circleSize + _circleDetection.CircleSize)*(_circleSize + _circleDetection.CircleSize) )
        {
            Gizmos.color = Color.green;
        }
    
        Gizmos.DrawSphere(transform.position, _circleSize);

        float DistanceVector(Vector2 circle, Vector2 point)
        {
            float num = circle.x - point.x;
            float num2 = circle.y - point.y;
            return num * num + num2 * num2;
        }
    }
}