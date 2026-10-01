using UnityEngine;
using System;

[Serializable]
public class Matrix2x2
{
    public float[,] matrix { get; set; }

    public Matrix2x2(float a, float b, float c, float d)
    {
        matrix = new float[2, 2];
        matrix[0, 0] = a;
        matrix[0, 1] = b;
        matrix[1, 0] = c;
        matrix[1, 1] = d;
    }

    public float Determinant()
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    public Vector3 Multiply(Vector3 vector)
    {
        float x = matrix[0, 0] * vector.x + matrix[0, 1] * vector.y;
        float y = matrix[1, 0] * vector.x + matrix[1, 1] * vector.y;
        return new Vector3(x, y, vector.z);
    }

}
