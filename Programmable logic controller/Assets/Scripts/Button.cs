using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IPress
{
    

    private bool _input = false ;
    private int _index = 0;
    
    public Material[] myMaterials;
    public Renderer rend;

    public bool Input => _input;
    
     public void Start()
     {
         rend = GetComponent<Renderer>();
         rend.enabled = true;
     }

    public void Press()
    {
        if (myMaterials.Length == 0)
        {
            return;
        }

        _index += 1;
        _input = true;
        if (_index == myMaterials.Length)
        {
            _input = false;
            _index = 0;
        }

        rend.sharedMaterial = myMaterials[_index];
    }
}
