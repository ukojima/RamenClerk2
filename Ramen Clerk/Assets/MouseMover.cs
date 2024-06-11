using UnityEngine;

public class MouseMover : MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;
    private float zCoord;
    private bool isDragging = false;

    void Start()
    {
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        zCoord = cam.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPos();
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPos() + offset;
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord; // Use the Z coordinate stored on mouse down
        return cam.ScreenToWorldPoint(mousePoint);
    }

    void Update()
    {
        if (isDragging)
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            if (scroll != 0.0f)
            {
                Vector3 position = transform.position;
                position.z += scroll;
                transform.position = position;
            }
        }
    }
}
