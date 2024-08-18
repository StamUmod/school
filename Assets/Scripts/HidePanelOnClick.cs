using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HidePanelOnClick : MonoBehaviour, IPointerClickHandler
{
    public GameObject panel; // 要隱藏的Panel物件
    public GameObject textObject; // 要隱藏的Text物件

    public void OnPointerClick(PointerEventData eventData)
    {
        // 隱藏Panel和Text
        panel.SetActive(false);
        textObject.SetActive(false);
    }
}