using UnityEngine;
using UnityEngine.InputSystem;

public class DraggablePoint : MonoBehaviour
{
    [SerializeField] InputActionReference PointAction;
    [SerializeField] InputActionReference PressAction;

    bool isDragging = false;

    void OnEnable()
    {
        PointAction.action.Enable();
        PressAction.action.Enable();

        PressAction.action.started += OnPress;
        PressAction.action.canceled += OnRelease;
    }


    void OnDisable()
    {
        PressAction.action.started -= OnPress;
        PressAction.action.canceled -= OnRelease;

        PressAction.action.Disable();
        PointAction.action.Disable();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (!isDragging)
        {
            return;
        }

        Vector2 mousePosition = PointAction.action.ReadValue<Vector2>();
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPosition.z = 0f;
        transform.position = worldPosition;
    }

    void OnRelease(InputAction.CallbackContext context)
    {
        isDragging = false;
    }

    void OnPress(InputAction.CallbackContext context)
    {
        Vector2 mousePosition = PointAction.action.ReadValue<Vector2>();

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPosition.z = 0f;

        Collider2D hit = Physics2D.OverlapPoint(worldPosition);

        if (hit != null && hit.gameObject == gameObject )
        {
            isDragging = true;
        }
    }
}
