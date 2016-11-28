using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    public Canvas quitMenu;
    public Button startText;
    public Button exitText;
    public Canvas CreditMenu;
    public Canvas InstruMenu;
    public Canvas FasesMenu;

	void Start ()
    {
        FasesMenu = FasesMenu.GetComponent<Canvas>();
        InstruMenu = InstruMenu.GetComponent<Canvas>();
        CreditMenu = CreditMenu.GetComponent<Canvas>();
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        CreditMenu.enabled = false;
        InstruMenu.enabled = false;
        FasesMenu.enabled = false;
    }

    public void ExitPress() 

    {
        quitMenu.enabled = true; 
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void Instru()

    {
        InstruMenu.enabled = true;
    }

    public void NoPress() 

    {
        quitMenu.enabled = false; 
        startText.enabled = true; 
        exitText.enabled = true;
        CreditMenu.enabled = false;
        InstruMenu.enabled = false;
        FasesMenu.enabled = false;
    }

    public void creditPress()

    {
        CreditMenu.enabled = true;
        startText.enabled = false;
    }

    
    public void StartLevel() 

    {
        Application.LoadLevel("Main");
        Voltar.contador = 0;
        Cursor.visible = false;
    }

    public void ExitGame() 

    {
        Application.Quit(); 
    }

    public void Fases()

    {
        FasesMenu.enabled = true;
    }

    



}
