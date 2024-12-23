using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;

    [SerializeField] private AudioClip tubeInHandsClip;
    [SerializeField] private AudioClip placeTubeInCellClip;
    private void Start()
    {
        image = GetComponent<Image>();  
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        SoundFXManager.SFXinstance.PlaySoundFXClip(tubeInHandsClip, transform, 0.3f);
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
        SoundFXManager.SFXinstance.PlaySoundFXClip(placeTubeInCellClip, transform, 0.03f);
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
