using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRendering : MonoBehaviour
{
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

}
