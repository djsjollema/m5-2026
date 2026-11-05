using UnityEngine;

public class Les7 : MonoBehaviour
{
    [SerializeField] Transform A;
    [SerializeField] GVector[] Vectors;

    float angle = 0;
    float magnitude = 0;

    void Start()
    {
        Vectors[1].vector = new Vector3(1, 0, 0); // x-vector
        Vectors[2].vector = new Vector3(0, 1, 0); // y-vector
    }

    void Update()
    {
        Vectors[0].vector = A.position;

        angle = Mathf.Atan2(Vectors[0].vector.y, Vectors[0].vector.x);
        magnitude = Vectors[0].vector.magnitude;

        Vectors[1].vector = new Vector3(magnitude * Mathf.Cos(angle), 0, 0);
        Vectors[2].vector = new Vector3(0, magnitude * Mathf.Sin(angle), 0);
    }
}
