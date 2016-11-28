using UnityEngine;
using System.Collections;

public class Vitoria : MonoBehaviour
{
    public string Fase;

    void OnTriggerEnter(Collider other)

    {
        Application.LoadLevel(Fase);
    }
}
