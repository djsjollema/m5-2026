using UnityEngine;

public class Les5 : MonoBehaviour
{
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    [SerializeField] Transform C;
    [SerializeField] Transform D;

    [SerializeField] pLine line1;
    [SerializeField] pLine line2;

    [SerializeField] Transform intersectionPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        line1.supportVector = A.position;
        line1.directionVector = B.position - A.position;

        line2.supportVector = C.position;
        line2.directionVector = D.position - C.position;
        
        intersectionPoint.position = line1.intersectionPoint(line2);
    }
}
