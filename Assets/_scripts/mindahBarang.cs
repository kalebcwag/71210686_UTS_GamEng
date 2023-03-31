using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mindahBarang : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;
    void OnMouseDown()
        {
            firstY = transform.position.x;
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
        }
    private void OnMouseUp()
    {
        transform.position = new Vector3(firstY, transform.position.x, transform.position.z);
        }
    }
