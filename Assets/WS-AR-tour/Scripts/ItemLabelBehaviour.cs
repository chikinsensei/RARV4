using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLabelBehaviour : MonoBehaviour {
    public Text Label;

	
	// Update is called once per frame
	void Update () {
		transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
	}

    public void UpdatePositionAndLabel(Transform labelPositionTransform, string label = "")
    {
		transform.position = labelPositionTransform.GetChild(0).position;
		transform.parent = labelPositionTransform.GetChild(0);
		Label.text = label;
    }
}
