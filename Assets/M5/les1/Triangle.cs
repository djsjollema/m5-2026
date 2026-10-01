using UnityEngine;

public class Triangle : MonoBehaviour
{
    [SerializeField] public Transform A;
    [SerializeField] public Transform B;
    [SerializeField] public Transform C;
    [SerializeField] private LineRenderer lr;

    void Start()
    {
        
    }

    void Update()
    {
        lr.SetPosition(0, A.localPosition);
        lr.SetPosition(1, B.localPosition);
        lr.SetPosition(2, C.localPosition);
    }
}
