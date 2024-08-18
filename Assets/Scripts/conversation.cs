using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conversation : MonoBehaviour
{
    public GameObject panel; // 要顯示的Panel物件
    private Button button; // 按鈕組件

    void Start()
    {
        button = GetComponent<Button>(); // 獲取按鈕組件
        button.onClick.AddListener(ShowPanel); // 添加點擊事件監聽

        // 初始時禁用Panel及其子組件
        DisablePanel(panel);
    }

    void ShowPanel()
    {
        panel.SetActive(true); // 顯示Panel

        // 遞迴啟用Panel的子組件
        EnableChildren(panel.transform);
    }

    void DisablePanel(GameObject panelObj)
    {
        panelObj.SetActive(false);
        foreach (Transform child in panelObj.transform)
        {
            DisablePanel(child.gameObject);
        }
    }

    void EnableChildren(Transform parent)
    {
        foreach (Transform child in parent)
        {
            child.gameObject.SetActive(true);
            EnableChildren(child);
        }
    }
}