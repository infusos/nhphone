using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LanguageSelectorController : MonoBehaviour {

	public GameObject languageListPanel;

	private bool isVisible = false;

	void Start () {

	}

	void Update () {
	
	}

	public void Toggle(){
		if (!isVisible) {
			languageListPanel.gameObject.transform.DOScaleY(1,0.15f);
		} else {
			languageListPanel.gameObject.transform.DOScaleY(0,0.15f);
		}
		isVisible = !isVisible;
	}
}
