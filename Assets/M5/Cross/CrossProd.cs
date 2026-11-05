using UnityEngine;

public class CrossProd : MonoBehaviour
{
    [SerializeField] Transform PointA;
    [SerializeField] Transform PointB;
    [SerializeField] Transform PointC;
    [SerializeField] Transform PointD;
    [SerializeField] pLine line1;
    [SerializeField] pLine line2;

    [SerializeField] Transform intersection;

    void Update()
    {
        line1.supportVector = PointA.position;
        line2.supportVector = PointC.position;
        line1.directionVector = (PointB.position - PointA.position).normalized;
        line2.directionVector = (PointD.position - PointC.position).normalized;

        Vector3 a = PointA.position;
        Vector3 b = PointC.position;

        Vector3 c = (PointB.position - PointA.position).normalized;
        Vector3 d = (PointD.position - PointC.position).normalized;
       
        float t = Vector3.Cross(b - a, d).z/ Vector3.Cross(c, d).z;

        intersection.position = a + t * c;
    }
}
