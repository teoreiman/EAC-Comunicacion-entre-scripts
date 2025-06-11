using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class piso_script : MonoBehaviour
{
    public UI_manager ui_Manager;
    public cubo_script Cubo_Script;

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cubo")
        {
            float peso = cubo_script.peso;
            ui_Manager.cambiar_texto(peso);
        }
    }
}