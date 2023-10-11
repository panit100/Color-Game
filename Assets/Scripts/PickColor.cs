using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PickColor : BlockColor, IDragHandler, IDropHandler, IBeginDragHandler
{
    
    Vector2 originPosition;

    public void SetOriginPosition()
    {
        originPosition = transform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        SetOriginPosition();
        GameManager.Instance.SetPickingColor(color);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnDrop(PointerEventData eventData)
    {
        transform.position = originPosition;
        GameManager.Instance.SetPickingColor(BlockColorType.None);
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        if(other.GetComponent<GuessBlock>() != null)
        {
            
        }
    }
}
