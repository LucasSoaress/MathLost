using UnityEngine;
using System.Collections;

public class MovimentoR : MonoBehaviour
{
    private float speedRotation;
    private bool couldMove;
    public int rotateType;


    void Start()
    {
        speedRotation = 45f;
    }


    void Update()
    {

        if (couldMove == true) // detectar area de colisão
        {
            switch (rotateType) // escolher o tipo de rotação da peça 
            {
                case 0: transform.localEulerAngles += new Vector3(0, speedRotation, 0) * Time.deltaTime; break;
                case 1: transform.localEulerAngles += new Vector3(0, 0, speedRotation) * Time.deltaTime; break;
            }

        }
    }


    void OnTriggerEnter(Collider c) // entrada da colisão
    {
        if (c.gameObject.tag.Equals("Player")) // testa a colisão
        {
            // Debug.Log("LOOOL"); // mostrar no console
            couldMove = true;
        }

    }

    void OnTriggerExit(Collider c) // saida da colisão
    {
        if (c.gameObject.tag.Equals("Player"))
        {
            //Debug.Log("xablaaaau"); // mostrar no console
            couldMove = false;
        }

    }
}
