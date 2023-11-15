using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryBtn : MonoBehaviour
{
    public Image my_image;
    public Image category_icon;
    public Button btn;
    private PopUpWindow holder;
    public string category_name;

    public void SetBtn(PopUpWindow parent)
    {
        holder = parent;
        btn.onClick.AddListener(delegate() {Activate();});
    }

    public void Activate()
    {
        SetAlpha(1.0f);
        if (holder.current_category != null)
            holder.current_category.SetAlpha(0f);
        holder.current_category = this;
    }

    public void SetAlpha(float alpha)
    {
        my_image.color = new Color(category_icon.color.r, category_icon.color.g, category_icon.color.b, alpha);
    }
}