using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeaderBarController : MonoBehaviour {

	public Text hour;
	public Text date;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		formatDatetime ();
	}

	private void formatDatetime(){
		var now = System.DateTime.Now;
		var hor = now.Hour;
		var minute = now.Minute;
		var day = now.Day;
		var month = now.Month;
		var dayofweek = now.DayOfWeek;
		hour.text = now.ToString("HH") + ":" + now.ToString ("mm");
		date.text = dayofweek.ToString ().Substring (0, 3) + ". " + day + " " + now.ToString ("MMM");
	}
}
