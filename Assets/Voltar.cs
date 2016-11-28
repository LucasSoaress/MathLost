using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Voltar : MonoBehaviour
{
    public Text Vida;
    public static int contador;
    public Canvas VezesMorreu;
    public Canvas VezesMorreu2;
    public Canvas VezesMorreu3;
    public string fase;
    

    void Start()

    {
        Vida.text =  contador.ToString();

        VezesMorreu = VezesMorreu.GetComponent<Canvas>();
        VezesMorreu.enabled = false;

        VezesMorreu2 = VezesMorreu2.GetComponent<Canvas>();
        VezesMorreu2.enabled = false;

        VezesMorreu3 = VezesMorreu3.GetComponent<Canvas>();
        VezesMorreu3.enabled = false;


        if (contador == 5)
         {
            VezesMorreu.enabled = true;  
         }

        if (contador == 15)

        { 
            VezesMorreu2.enabled = true;
        }

        if (contador == 30)

        { 
            VezesMorreu3.enabled = true;
        }

    }

    void Update()
    {
        if (contador == 5)
        {
            Cursor.visible = true;
        }

        if (contador == 15)
        {
            Cursor.visible = true;
        }

        if (contador == 30)
        {
            Cursor.visible = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(fase);
        contador = contador += 1;
        //Debug.Log("Ele pulou " + contador);
    }

    public void fechar()
    {
        VezesMorreu.enabled = false;
        VezesMorreu2.enabled = false;
        VezesMorreu3.enabled = false;
        Cursor.visible = false;
    }

    public void MenuPrincipal()
    {
        Application.LoadLevel("Menu");
    }

    public void sair()
    {
        Application.Quit();
    }

}
