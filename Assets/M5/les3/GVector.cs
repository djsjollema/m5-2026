using UnityEngine;

public class GVector : MonoBehaviour
{
    public Vector3 vector = new Vector3(2, 3, 0);

    [SerializeField] Transform head;
    [SerializeField] LineRenderer lr;
    void Start()
    {
       
    }

    void Update()
    {
        lr.SetPosition(1, new Vector3(vector.magnitude, 0, 0));
        head.localPosition = new Vector3(vector.magnitude, 0, 0);
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg);
    }
}
