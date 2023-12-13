using UnityEditor;
using UnityEngine;

public class CreateShape : MonoBehaviour
{
    [SerializeField, Range(2, 10)] private int numberPointsShape;
    private const float Tau = 2 * Mathf.PI;
    private float _angle;
    private void OnDrawGizmos() 
    {
        Handles.color = Color.yellow;
        
        Vector2[] PointArray = new Vector2[numberPointsShape];
        
        
        for(int index = 0; index < numberPointsShape; index++)
        {
            _angle = Tau / numberPointsShape;
            _angle *= index + 1;
            float x = Mathf.Cos(_angle) + transform.position.x;
            float y = Mathf.Sin(_angle) + transform.position.y;
            Vector2 nextPoint = new Vector2(x,y);
            PointArray[index] = nextPoint;
        }

        Handles.DrawLine(PointArray[PointArray.Length - 1], PointArray[0]);

        for (int i = 1; i < PointArray.Length; i++)
        {
            Handles.DrawLine(PointArray[i-1], PointArray[i]);
        }
        
    }
    
}