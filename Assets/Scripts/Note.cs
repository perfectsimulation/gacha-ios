﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float xPosition;
    public float zPosition;
    public float zScale; // length of note
    private Transform noteTransform;
    private float Y_POSITION = 1.1f;
    private float X_SCALE = 1f;
    private float Y_SCALE = 0.2f;

    void Start()
    {
        // Cache the note transform
        this.noteTransform = this.transform;
        // Set position and scale
        this.noteTransform.position = new Vector3(this.xPosition, Y_POSITION, this.zPosition);
        this.noteTransform.localScale = new Vector3(this.X_SCALE, this.Y_SCALE, this.zScale);
    }

    void Update()
    {
        // TODO
    }
}
