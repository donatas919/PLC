using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputHolder : MonoBehaviour, IPress
{
    private int _index = 0;
    private bool _input = false;
    private int _representingButton = -1;
    
    public Material[] myMaterials;
    public Renderer rend;
    public Button[] buttons;

    public TextMeshPro textMesh;
    //public GameObject buttonMenu;


    public bool Input => _input;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.material.color = Color.blue;

        textMesh = GetComponent<TextMeshPro>();
        textMesh.text =  "none";
    }

    // public void Update()
    // {
    //     if (_index)
    //     {
    //         rend.sharedMaterial = myMaterials[1];
    //     }
    //     else
    //     {
    //         rend.sharedMaterial = myMaterials[0];
    //     }
    // }
    
    public void HolderStatus()
    {
        // if (buttons.Length == 0)
        // {
        //     return;
        // }
        //
        // _index += 1;
        // if (_index == myMaterials.Length)
        // {
        //     _index = 0;
        // }
        //
        // _representingButton += 1;
        // if (_representingButton == myMaterials.Length)
        // {
        //     _representingButton = 0;
        // }
        //
        // rend.sharedMaterial = myMaterials[_index];
        // _input = buttons[_index].Input;
        // throw new NotImplementedException();
        // if (myMaterials.Length == 0)
        // {
        //     return;
        // }
        //
        // if (_buttonRepresentation = )
        // {
        //     
        // }
        // _index += 1;
        // if (_index == myMaterials.Length)
        // {
        //     _index = 0;
        // }
        //
        // rend.sharedMaterial = myMaterials[_index];
    }

    public void Press()
    {
        if (buttons.Length == 0)
        {
            return;
        }

        _representingButton++;
        if (_representingButton == buttons.Length)
        {
            _representingButton = -1;
            _input = false;
            textMesh.GetComponent<TextMeshProUGUI>().text = "none";
            return;
        }

        _input = buttons[_representingButton];
        textMesh.GetComponent<TextMeshProUGUI>().text = _representingButton.ToString();
        // _index += 1;
        // if (_index == myMaterials.Length)
        // {
        //     _index = 0;
        // }
        //
        // _representingButton += 1;
        // if (_representingButton == myMaterials.Length)
        // {
        //     _representingButton = 0;
        // }
        //
        // rend.sharedMaterial = myMaterials[_index];
        // _input = buttons[_index].Input;
    }
}
