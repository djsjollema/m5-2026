using UnityEngine;

public class Les3 : MonoBehaviour
{ 
    [SerializeField] Transform A;
    [SerializeField] Transform B;

    [SerializeField] GVector GVectorA;
    [SerializeField] GVector GVectorB;

    [SerializeField] LineRenderer line;

    Vector3 supportVector;
    Vector3 directionVector;

    void Update()
    {
        supportVector = new Vector3(A.position.x, A.position.y, 0);
        GVectorA.vector = supportVector;

        directionVector = B.position - A.position;
        directionVector = directionVector.normalized;

        GVectorB.transform.localPosition = new Vector3(A.position.x, A.position.y, 0);
        GVectorB.vector = directionVector;

        line.SetPosition(0, supportVector + -20*directionVector);
        line.SetPosition(1, supportVector + 20 * directionVector);

    }
}
