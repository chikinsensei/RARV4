using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickElementBehaviour : MonoBehaviour
{
	[SerializeField] private ItemLabelBehaviour labelBehaviour;

	private void Awake()
	{
		labelBehaviour = GameObject.Find("ItemLabel").GetComponent<ItemLabelBehaviour>();
	}
	private void OnMouseDown()
	{
		labelBehaviour.UpdatePositionAndLabel(transform, this.gameObject.name);
	}
}
