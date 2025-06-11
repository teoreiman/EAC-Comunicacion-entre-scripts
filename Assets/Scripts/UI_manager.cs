using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_manager : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public void cambiar_texto (float texto)
    {
        texto.text = "pesa " + peso;
    }
    

}
