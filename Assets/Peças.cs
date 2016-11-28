﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Peças : MonoBehaviour {
     private float speedRotation;
     private bool couldMove;
     public int rotateType;
     public Canvas Aviso;


    void Start () 
    {
        speedRotation = 31f; // velocidade da rotação
        Aviso = Aviso.GetComponent<Canvas>();
        Aviso.enabled = false;
     }


    void Update () 
    {
        if (Input.GetKey(KeyCode.X) == true && couldMove == true) // detectar area de colisão
        {
	         switch(rotateType) // escolher o tipo de rotação da peça 
             {
                 case 0: transform.localEulerAngles += new Vector3(0, speedRotation, 0) * Time.deltaTime; break;
                 case 1: transform.localEulerAngles += new Vector3(0, 0, speedRotation) * Time.deltaTime; break;
                 case 2: transform.localEulerAngles += new Vector3(speedRotation, 0, 0) * Time.deltaTime; break;
            }
        }
	}

    void OnTriggerEnter(Collider c) // entrada da colisão
    {
        if (c.gameObject.tag.Equals("Player")) // testa a colisão
        {
            //Debug.Log("LOOOL"); // mostrar no console
            couldMove = true;
            Aviso.enabled = true;

        }
            
    }

    void OnTriggerExit(Collider c) // saida da colisão
    {
        if (c.gameObject.tag.Equals("Player"))
        {
            //Debug.Log("xablaaaau"); // mostrar no console
            couldMove = false;
            Aviso.enabled = false;

        }

    }
}
