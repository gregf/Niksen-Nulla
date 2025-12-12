using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragWindow : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler
{
    //must be the parent of the window we are trying to move
    [SerializeField] private RectTransform dragRectTransform;
    [SerializeField] private Canvas canvas;
    [SerializeField] private Image backgroundImage;
    private Color backgroundColor;


    private void Awake()
    {
        backgroundColor = backgroundImage.color;
    }


    public void OnBeginDrag(PointerEventData eventData){
        //makes the window slightly transparent when dragging
        backgroundColor.a = .4f;
        backgroundImage.color = backgroundColor;
    }


    public void OnDrag(PointerEventData eventData){
        //makes any object that has the code able to be "dragged"
        dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }



    public void OnEndDrag(PointerEventData eventData){
        //makes it full color again
        backgroundColor.a = 1f;
        backgroundImage.color = backgroundColor;       
    }


    public void OnPointerDown(PointerEventData eventData){
        //makes window go in front of everything
        dragRectTransform.SetAsLastSibling();
    }
}
