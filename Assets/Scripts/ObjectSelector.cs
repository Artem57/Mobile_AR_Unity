using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{

	public GameObject objct;
	public GameObject targetObject;
	public GameObject listView;
	public ScaleChanger sc;
	public void SelectAndShow()
	{
	listView.SetActive(false);

	if(targetObject.GetComponent<Transform>().childCount > 0)
	{
		Transform child = targetObject.GetComponent<Transform>().GetChild(0);
		Destroy(child.gameObject);
	}

	GameObject model = Instantiate(objct);
	model.GetComponent<Transform>().localScale = new Vector3(3.5f, 3.5f, 3.5f);
	model.GetComponent<Transform>().SetParent(targetObject.GetComponent<Transform>());
	model.GetComponent<Transform>().localPosition = Vector3.zero;
	model.GetComponent<Transform>().localRotation = Quaternion.identity;
	sc.startingScale = model.GetComponent<Transform>().localScale;
	}

}
