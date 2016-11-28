using UnityEngine;
using System.Collections;

public class MiniMapaCamera : MonoBehaviour
{
    public Transform Boneco;

	void LateUpdate ()
    {
        transform.position = new Vector3(Boneco.position.x, transform.position.y, Boneco.position.z);
	}
}
