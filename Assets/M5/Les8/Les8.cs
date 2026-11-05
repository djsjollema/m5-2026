using UnityEngine;

public class Les8 : MonoBehaviour
{
    [SerializeField] Transform[] Points;
    [SerializeField] pLine[] Lines;
    [SerializeField] GVector[] Vectors;

    void Start()
    {
        Lines[0].SetColor(Color.red);
        Lines[1].SetColor(Color.yellow);
        
    }

    void Update()
    {
        Vectors[0].transform.position = Points[0].position;                                                                                                                                                 
        Vectors[0].vector = Points[1].position - Points[0].position;

        Lines[0].supportVector = Points[0].position;
        Lines[0].directionVector = (Points[2].position - Points[0].position).normalized;

        Lines[1].supportVector = Points[0].position;
        Lines[1].directionVector = new Vector3(-Lines[0].directionVector.y, Lines[0].directionVector.x, 0).normalized;

        Vectors[1].transform.position = Points[0].position;
        Vectors[2].transform.position = Points[0].position;

        Vectors[1].vector = Lines[0].directionVector;
        Vectors[2].vector = Lines[1].directionVector;

        Vectors[1].vector = Vectors[1].vector * Vector3.Dot(Vectors[0].vector, Vectors[1].vector);
        Vectors[2].vector = Vectors[2].vector * Vector3.Dot(Vectors[0].vector, Vectors[2].vector);

    }
}