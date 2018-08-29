using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleChanger : MonoBehaviour
{

	public Slider slider;
	public GameObject parent;
	public Vector3 startingScale;

	void Start()
	{
		slider.onValueChanged.AddListener(delegate {ChangeScale();});
	}

	public void ChangeScale()
	{
			if(parent.transform.childCount > 0)
			{
				GameObject child = parent.transform.GetChild(0).gameObject;
				child.transform.localScale = startingScale * slider.value;
			}
	}

}
