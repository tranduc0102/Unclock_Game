using System;
using System.Collections;
using System.Collections.Generic;
using GameTool;
using UnityEngine;

public class Vong : BasePooling
{
    // Start is called before the first frame updat

    private void OnEnable()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.13f, 0f);
        transform.localScale = new Vector3(0.2979257f, 0.2954848f, 0f);
    }

    private void Update()
    {
        
    }
}
