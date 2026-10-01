using UnityEngine;

public class pLine : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;


    public Vector3 supportVector = new Vector3(0, 0, 0);
    public Vector3 directionVector = new Vector3(1, 2, 0);
    public float parameter;

    // Update is called once per frame
    void Update()
    {
        directionVector.Normalize();
        lineRenderer.SetPosition(0, supportVector -20 * directionVector);
        lineRenderer.SetPosition(1, supportVector + 20 * directionVector);
    }

    public Vector3 intersectionPoint(pLine otherLine)
    {
        Matrix2x2 matrix = new Matrix2x2(directionVector.x, -otherLine.directionVector.x, directionVector.y, -otherLine.directionVector.y);
        float determinant = matrix.Determinant();

        if (determinant == 0)
        {
            Debug.Log("Lines are parallel");
            return Vector3.zero;
        }

        float a = otherLine.supportVector.x - supportVector.x;
        float b = otherLine.supportVector.y - supportVector.y;

        float c = -otherLine.directionVector.x;
        float d = -otherLine.directionVector.y;

        Matrix2x2 leftMatrix = new Matrix2x2(a, b, c, d);
        float t1 = leftMatrix.Determinant() / determinant;

        Vector3 intersectionPoint = supportVector + t1 * directionVector;

        return intersectionPoint;
    }



}
