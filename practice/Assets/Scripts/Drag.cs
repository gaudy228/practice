using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;
    [SerializeField] private AudioClip tubeInHandsClip;
    private void Start()
    {
        image = GetComponent<Image>();  
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        SoundFXManager.instance.PlaySoundFXClip(tubeInHandsClip, transform, 1f);
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
       
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
