﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lean : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Input.GetAxis("Horizontal"),0,0);
        transform.Rotate(Input.GetAxis("Vertical"),0,0);
    }
}
