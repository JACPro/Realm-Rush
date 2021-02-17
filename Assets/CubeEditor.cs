﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    [Range(1f, 20f)] [SerializeField] float gridSize = 10f;

    TextMesh label;

    void Awake() {
        label = GetComponentInChildren<TextMesh>();            
    }

    void Update()
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;


        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        //update cube label
        label.text = snapPos.x / gridSize + "," + snapPos.z / gridSize;
    }
}