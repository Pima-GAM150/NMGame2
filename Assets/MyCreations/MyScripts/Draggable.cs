using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject selectablePrefab;

    public Vector3 startingPos;

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        

        
        gameObject.transform.position = eventData.position;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
       Instantiate(selectablePrefab, eventData.worldPosition, Quaternion.identity);  
    }
}
