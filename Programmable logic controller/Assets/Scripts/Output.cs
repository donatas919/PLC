using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Output : MonoBehaviour
{
    private bool _output = false;
    private int _index = 0;

    public List<InputHolder> inputs;
    public Material[] materials;
    public Renderer rend;


    public void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    public List<InputHolder> Inputs
    {
        get => inputs;
        set => inputs = value;
    }

    public void Update()
    {
        LadderLogickCheck();
    }

    public void LadderLogickCheck()
    {
        // if (_output)
        // {
        //     return;
        // }
        foreach (var input in inputs)
        {
            _output = input.Input;
            if (_output==false)
            {
                OutputStatus();
                break;
            }
        }

        if (_output)
        {
            OutputStatus();
        }
    }
    
    private void OutputStatus()
    {
        if (materials.Length == 0)
        {
            return;
        }

        if (_output && _index == 1)
        {
            return;
        }
        
        if (_output == false && _index == 0)
        {
            return;
        }

        _index += 1;
        if (_index == materials.Length)
        {
            _index = 0;
        }

        rend.sharedMaterial = materials[_index];
    }
}
 