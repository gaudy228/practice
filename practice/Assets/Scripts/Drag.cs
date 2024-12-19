using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;
    private void Start()
    {
        image = GetComponent<Image>();  
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Beg");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
