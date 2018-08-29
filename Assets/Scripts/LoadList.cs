using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadList : MonoBehaviour {

    public GameObject prefab;
    public GameObject target;
    public ScaleChanger Changer;
    public Transform parentTransform;

    void Start()
    {
      Object[] objectList = Resources.LoadAll("Objects/", typeof(GameObject));
      GameObject tmp;
      foreach(GameObject obj in objectList)
      {
        tmp = Instantiate(prefab);
        tmp.GetComponent<ObjectSelector>().objct = obj;
        tmp.GetComponent<ObjectSelector>().targetObject = target;
        tmp.GetComponent<ObjectSelector>().listView = this.gameObject;
        tmp.GetComponent<Transform>().GetChild(0).GetComponent<Text>().text = obj.name;
        tmp.GetComponent<Transform>().SetParent(parentTransform);
        tmp.GetComponent<ObjectSelector>().sc = Changer;
      }
      this.gameObject.SetActive(false);
    }

}
