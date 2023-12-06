using UnityEngine;

public class CircleGizmos : MonoBehaviour
{
    [SerializeField] [Range(0,10)] private float circleSize;
    [SerializeField] GameObject point;

    private void OnDrawGizmos() 
    {
        if(Vector2.Distance(transform.position,point.transform.position) <= circleSize)
        {
            Gizmos.color = Color.green;
        }
        Gizmos.DrawSphere(transform.position, circleSize);
    }
}


//Longueur de la distance centre du cercle -> point est plus petite ou égale au rayon du cercle alors le point est dans le cercle