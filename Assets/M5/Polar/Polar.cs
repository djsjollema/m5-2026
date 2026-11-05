
using UnityEngine;
using UnityEngine.InputSystem;

public class Polar : MonoBehaviour
{
    [SerializeField] Transform arrow;
    [SerializeField] InputActionReference PointAction;
    [SerializeField] InputActionReference PressAction;

    void OnEnable()
    {
        PointAction.action.Enable();
        PressAction.action.Enable();

        PressAction.action.started += OnPress;
    }

    void OnDisable()
    {
        PressAction.action.started -= OnPress;
        PressAction.action.Disable();
        PointAction.action.Disable();
    }

    void OnPress(InputAction.CallbackContext context)
    {
        Vector2 mousePosition = PointAction.action.ReadValue<Vector2>();

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(
            new Vector3(mousePosition.x, mousePosition.y,
                -Camera.main.transform.position.z)
        );

        Vector2 direction = worldPosition - arrow.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        arrow.rotation = Quaternion.Euler(0, 0, angle);
    }
}
