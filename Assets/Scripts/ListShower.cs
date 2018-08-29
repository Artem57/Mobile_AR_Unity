using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListShower : MonoBehaviour
{

public void ShowOrHide(GameObject target)
	{
		if(!target.activeInHierarchy)
		{
			target.SetActive(true);
		}
		else
		{
			target.SetActive(false);
		}
	}

}
