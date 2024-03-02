using System;
using System.Collections;
using System.Collections.Generic;
using GameTool;
using UnityEditor;
using UnityEngine;

public class PhuKienDiChuyen : BasePooling
{
    public List<Sprite> s = new List<Sprite>();
    public SpriteRenderer sr;
    public float Timex = 60f;

    private void OnEnable()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Timex -= 0.5f;
        if (Timex >= 35f)
        {
            sr.sprite = s[2];
        }
        else if (Timex < 35f && Timex >= 15f)
        {
            sr.sprite = s[1];
        }
        else
        {
            sr.sprite = s[0];
        }

        if (Timex <= 0)
        {
            Timex = 36f;
        }
    }
}
