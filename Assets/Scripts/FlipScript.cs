using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipScript : MonoBehaviour
{

	public Transform parent;

	public void Flip()
	{
		if(parent.childCount > 0)
		{
			GameObject child = parent.GetChild(0).gameObject;
			if(child.transform.eulerAngles.y != 0)
			{
				child.transform.RotateAround(child.transform.localPosition, Vector3.up, -90.0f);
			}
			else
			{
				child.transform.RotateAround(child.transform.localPosition, Vector3.up, 90.0f);
			}
		}
	}

}
