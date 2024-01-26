using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickElementBehaviour : MonoBehaviour
{
	private void OnMouseDown()
	{
		Debug.Log(this.gameObject.name);
	}
}
