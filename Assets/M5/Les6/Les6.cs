using UnityEngine;

public class Les6 : MonoBehaviour
{
    [SerializeField] Transform pointA;
    [SerializeField] Transform pointB;

    [SerializeField] pLine line;

    [SerializeField] GVector vector;

    Matrix2x2 M;

    void Update()
    {
        M = new Matrix2x2(0,-1,1,0);
        line.supportVector = pointA.position;
        line.directionVector = (pointB.position - pointA.position).normalized ;

        vector.vector = line.directionVector;
        vector.transform.position = pointA.position + 0.5f * (pointB.position - pointA.position);

        vector.vector = M.Multiply(line.directionVector);


    }
}
