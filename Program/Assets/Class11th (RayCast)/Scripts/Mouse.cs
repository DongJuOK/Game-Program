using System;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;

    [SerializeField] float duration = 1.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // 0번이 왼쪽, 1번이 오른쪽
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
            {
                Debug.DrawLine(ray.origin, raycastHit.point, Color.blue, duration);
            }
        }
    }
}
