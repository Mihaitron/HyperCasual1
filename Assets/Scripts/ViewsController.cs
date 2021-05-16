using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ViewsController : MonoBehaviour
{
    [SerializeField] private TMP_Text views;

    private long viewsNumber;

    private void Start()
    {
        viewsNumber = 0;
    }

    public void AddViews(int added)
    {
        viewsNumber += added;
        if (viewsNumber > 999999)
        {
            var ks = viewsNumber / 1000000;
            var dot = viewsNumber / 100000 % 10;
            views.text = String.Concat(ks.ToString(), ".", dot.ToString(), "M");
        }
        else if (viewsNumber > 999)
        {
            var ks = viewsNumber / 1000;
            var dot = viewsNumber /100 % 10;
            views.text = String.Concat(ks.ToString(), ".", dot.ToString(), "K");
        }
        else
        {
            views.text = viewsNumber.ToString();
        }
    }
}
