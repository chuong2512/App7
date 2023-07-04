using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// /////////
/// </summary>
public class ButtonRegister : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI TextMeshProUgui;
    public Button button;

    private void SetTextDay()
    {/////////////
        switch (number)
        {
            case 1:
                TextMeshProUgui.SetText("Mua thêm ưu đãi 1 ngày");
                break;
            case 2:
                TextMeshProUgui.SetText("Mua thêm ưu đãi 7 ngày");
                break;
            case 3:
                TextMeshProUgui.SetText("Mua thêm ưu đãi 30 ngày");
                break;
            case 4:
                TextMeshProUgui.SetText("Mua thêm ưu đãi 90 ngày");
                break;
            case 5:
                TextMeshProUgui.SetText("Mua thêm ưu đãi 180 ngày");
                break;
        }
    }
    
    void OnValidate()
    {
        TextMeshProUgui = GetComponentInChildren<TextMeshProUGUI>();
        button = GetComponentInChildren<Button>();
    }

    void Start()
    {
        button.onClick.AddListener(Choose);

        SetTextDay();
    }



    private void Choose()
    {
        RegisterManager.Instance.OnPressDown(number);
    }
}