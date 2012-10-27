using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;


public class DetectDevice  {
	
#if UNITY_IPHONE
	[DllImport ("__Internal")]
	private static extern string GetDeviceModel();
	
	public static string GetDevice()
	{
		return GetDeviceModel();
	}
#endif

}
