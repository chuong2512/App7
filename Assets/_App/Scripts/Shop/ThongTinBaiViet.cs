using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ThongTinBaiViet : ManHinh
{
    public Image image;
    public TextMeshProUGUI name, thongTin, gia;
    private int ID;


    public void ShowInfo(int id)
    {
        var sanPham = GameDataManager.Instance.SanPhamSo.GetSanPhamWithID(id);

        SetInfo(sanPham);
    }
    
    private void Save()
    {
        GameDataManager.Instance.TickSave(ID);
    }

    public void ShowInfoShop()
    {
        PurchasingManager.Instance.Show(ID);
    }

    public void SetInfo(SanPham product)
    {
        ID = product.ID;
        image.sprite = product.anh;
        name?.SetText(product.name);
        gia?.SetText(product.gia);
        thongTin?.SetText(product.thongTin);
    }

}
