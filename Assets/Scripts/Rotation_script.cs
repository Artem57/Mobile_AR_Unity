using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_script : MonoBehaviour {

    public float speed = 20.0f;
    public GameObject target;
    public bool inverse;

	public void OnMouseDown()
    {
        if(inverse == true)
        {
            target.transform.Rotate(Vector3.right * speed * Time.deltaTime);
            Debug.Log("Left");
        }
        else
        {
            target.transform.Rotate(Vector3.left * speed * Time.deltaTime);
            Debug.Log("Right");
        }
    }

}
