using UnityEngine;
using System.Collections;

public class BaseApplication : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//string a = string.Format("{0:HH:mm:ss tt}", Dat)
		var date = System.DateTime.Now;
		date.ToString ("HH:mm:ss");
		Debug.Log (date);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
