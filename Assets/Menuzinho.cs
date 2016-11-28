using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menuzinho : MonoBehaviour 
{
    public Canvas escMenu;
    private bool menuAtivo;
    
	void Start () 
    {
        escMenu = escMenu.GetComponent<Canvas>();
        escMenu.enabled = false;
        Time.timeScale = 1f;
        Cursor.visible = false;   
    }
	
    public void VoltarPress ()
    {
        menuAtivo = false;
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

    public void SairPress()
    {
        Application.Quit();
    }

    public void MenuPress()
    {
        Application.LoadLevel("Menu");
    }

    public void Restart()
    {
        Application.LoadLevel("Main");
        Voltar.contador = 0;
    }

    void Update () 
    {

        if (Input.GetKeyDown(KeyCode.Escape))

        {
            if (menuAtivo == true)
            {
                menuAtivo = false;
            }

            else if (menuAtivo == false)
            {
                menuAtivo = true;
            }
        }

        if (menuAtivo == true)
        {
            escMenu.enabled = true;
            Time.timeScale = 0.0f;
            Cursor.visible = true;
        }

        if (menuAtivo == false)
        {
            escMenu.enabled = false;
            Time.timeScale = 1f;
            Cursor.visible = false;
        }

     }
}
