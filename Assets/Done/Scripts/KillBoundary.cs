using UnityEngine;
using System.Collections;

public class KillBoundary : MonoBehaviour
{
	void OnTriggerExit (Collider other) 
	{
		Destroy(other.gameObject);
	}
}