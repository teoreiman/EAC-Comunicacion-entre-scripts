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
    
    // Start is called before the first frame update
    void Start()
    {
    
    }
}


    // Update is called once per frame
    void Update()
    {
    
    }
}
