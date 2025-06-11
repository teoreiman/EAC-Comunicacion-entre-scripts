using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_manager : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public void cambiar_texto (float peso)
    {
        texto.text = "pesa " + peso;
    }
    

}
