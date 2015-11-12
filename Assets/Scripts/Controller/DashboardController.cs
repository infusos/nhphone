using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DashboardController : MonoBehaviour {

	public List<GameObject> items;
	public bool isVisible = true;

	void Start () {

	}

	void Update () {
	
	}

	public void Toggle(){
		if (isVisible) {
			foreach (GameObject item in items) {
				item.gameObject.transform.DOScaleX(0,0.15f);
			}
		} else {
			foreach(GameObject item in items){
				item.gameObject.transform.DOScaleX(1,0.15f);
			}
		}
		isVisible = !isVisible;
	}
}
