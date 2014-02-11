using UnityEngine;
using System.Collections;

public class WWWCrash : MonoBehaviour {

	IEnumerator Start()
	{
		while(true)
		{
			Debug.Log("Start DL");
			WWW www = new WWW("http://www.dhxmedia.com/images/banners/shows/banner_03.jpg");
			{
				yield return www;
			}
			www.Dispose();
			yield return new WaitForSeconds(1.0f);
			Debug.Log("Finish DL");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
