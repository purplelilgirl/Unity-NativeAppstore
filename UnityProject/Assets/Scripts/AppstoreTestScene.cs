using UnityEngine;
using System.Collections;

public class AppstoreTestScene : MonoBehaviour 
{
	public string m_appID_IOS = "840066184";
	public string m_appID_Android = "com.orangenose.noone";

	public void OnButtonClick(string buttonName)
	{	
		if(buttonName == "ViewApp")
		{	
			if(!Application.isEditor)
			{
				#if UNITY_IPHONE
				AppstoreHandler.Instance.openAppInStore(m_appID_IOS);
				#endif

				#if UNITY_ANDROID
				AppstoreHandler.Instance.openAppInStore(m_appID_Android);
				#endif
			} else
			{	Debug.Log("AppstoreTestScene:: Cannot view app in Editor.");
			}
		}
	}
}
