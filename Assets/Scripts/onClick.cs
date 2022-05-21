using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class onClick : MonoBehaviour, IPointerClickHandler
{
    public GameObject selectedObject;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("aaa");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
            }
        }

        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
            Debug.Log("sss");
        }
    }
}
