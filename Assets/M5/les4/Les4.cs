using UnityEngine;

public class Les4 : MonoBehaviour
{
    [SerializeField] Transform Ball;
    Vector3 velocity = new Vector3(2, 3, 0);

    public Matrix2x2 ReflectInXAxis;
    public Matrix2x2 ReflectInYAxis;

    Vector2 minScreen, maxScreen;

    void Start()
    {
        ReflectInXAxis = new Matrix2x2(1, 0, 0, -1);
        ReflectInYAxis = new Matrix2x2(-1, 0, 0, 1);
        minScreen = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxScreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));
    }

    void Update()
    {
        transform.position += velocity * Time.deltaTime;

        if(Ball.position.y > maxScreen.y || Ball.position.y < minScreen.y)
        {
            velocity = ReflectInXAxis.Multiply(velocity);
        }

        if(Ball.position.x > maxScreen.x || Ball.position.x < minScreen.x)
        {
            velocity = ReflectInYAxis.Multiply(velocity);
        }
    }
}
