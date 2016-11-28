using UnityEngine;
using System.Collections;

public class Transparente : MonoBehaviour
{
    public Material normal;
    public Material transparente;
	
	void Start ()
    {
        GetComponent<Renderer>().material = normal;
    }
	
    void OnTriggerEnter(Collider C)
    {
        if (C.gameObject.tag.Equals("MainCamera"))
        {
            GetComponent<Renderer>().material = transparente;
        }
    }

    void OnTriggerExit(Collider C)
    {
        if (C.gameObject.tag.Equals("MainCamera"))
        {
            GetComponent<Renderer>().material = normal;
        }
    }
}
