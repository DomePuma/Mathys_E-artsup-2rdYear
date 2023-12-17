using UnityEditor;
using UnityEngine;

public class CreateShape : MonoBehaviour
{
    private const float Tau = 2 * Mathf.PI;
    [SerializeField, Range(2, 10)] private int _numberPointsShape;
    private float _angle;
    
    private void OnDrawGizmos() 
    {
        Handles.color = Color.yellow;
        
        Vector2[] pointArray = new Vector2[_numberPointsShape];
        
        for(int index = 0; index < _numberPointsShape; index++)
        {
            _angle = Tau / _numberPointsShape;
            _angle *= index + 1;
            float x = Mathf.Cos(_angle) + transform.position.x;
            float y = Mathf.Sin(_angle) + transform.position.y;
            Vector2 nextPoint = new Vector2(x,y);
            pointArray[index] = nextPoint;
        }

        Handles.DrawLine(pointArray[pointArray.Length - 1], pointArray[0]);

        for (int i = 1; i < pointArray.Length; i++)
        {
            Handles.DrawLine(pointArray[i-1], pointArray[i]);
        } 
    }
}