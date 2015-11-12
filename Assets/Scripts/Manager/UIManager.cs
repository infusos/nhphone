using UnityEngine;
using System.Collections;
using DG.Tweening;

public class UIManager : MonoBehaviour {

	private int mCurrentScreen = Constants.SCREEN_DASHBOARD;
	public GameObject panelDashboard;
	public GameObject panelHotelDirectory;

	void Start () {
	
	}

	void Update () {
	
	}

	public void OnClick(GameObject item){
		Debug.Log ("ITEM TAG: " + item.tag);
		if (item.layer == 8) {
			panelDashboard.GetComponent<DashboardController>().Toggle();
			if(item.CompareTag("HotelDirectory")){
				panelHotelDirectory.SetActive(true);
				panelHotelDirectory.GetComponent<DashboardController>().Toggle();

			}
		}

	}
}
