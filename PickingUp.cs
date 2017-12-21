using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    //PickingUp pickingUp = new PickingUp();

    public bool IsDestroyed;
	

	public void OnTriggerEnter (Collider other)
    {

        if (other.gameObject.CompareTag("Pickup"))

        {
            Destroy(other.gameObject);
            IsDestroyed = true;

        }
	}
}


