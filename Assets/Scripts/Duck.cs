﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour {

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
