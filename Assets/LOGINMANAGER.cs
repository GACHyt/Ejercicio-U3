using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Cuando el usuario presione el boton "btn_Aceptar" debe escribirse un mensaje en la consola
//Si el texto del inputPassword coincide con una contraseña predefiida por ustedes,
//Escribir "Acces Granted", sino escribir "Acces Denied"

public class LOGINMANAGER : MonoBehaviour
{
    public string Contraseña;
    public Text InputContraseña;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MostrarMensaje()
    {
        if (InputContraseña.text==Contraseña)
        {
            Debug.Log("Acces Granted");
        }
        else
        {
            Debug.Log("Acces Denied");
        }
    }
}
