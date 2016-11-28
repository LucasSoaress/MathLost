using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VitoriaScript : MonoBehaviour
{
    public Canvas Vitoria;
    public Button Fechar;
    public Button Reiniciar;
    public Button Menu;

	
	void Start ()
    {
        Vitoria = Vitoria.GetComponent<Canvas>();
        Vitoria.enabled = true;
    }
	
	public void fechar()
    {
        Application.Quit();
    }

    public void MenuPrincipal()
    {
        Application.LoadLevel("Menu");
    }

    public void ReiniciarJogo()
    {
        Application.LoadLevel("Main");
    }
}
