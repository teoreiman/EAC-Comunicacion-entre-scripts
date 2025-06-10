using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class piso_script : MonoBehaviour
{
    public UI_manager ui_Manager;
    public cubo_script;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cubo")
        {
            float peso = cubo_script.peso;
            
        }
    }
