using UnityEngine;

public class Les2 : MonoBehaviour
{
    [SerializeField] Triangle triangle;
    [SerializeField] Transform hAB;
    [SerializeField] Transform hBC;
    [SerializeField] Transform hCA;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hAB.position = triangle.A.position + 0.5f * (triangle.B.position - triangle.A.position);
        hBC.position = triangle.B.position + 0.5f * (triangle.C.position - triangle.B.position);
        hCA.position = triangle.C.position + 0.5f * (triangle.A.position - triangle.C.position);

        
    }
}
