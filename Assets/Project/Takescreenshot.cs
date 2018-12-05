using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takescreenshot : MonoBehaviour {

	// Use this for initialization
	void screenshotandsave () {
		StartCoroutine( TakeScreenshotAndSave() );
	}
	
	private IEnumerator TakeScreenshotAndSave()
{
	yield return new WaitForEndOfFrame();

	Texture2D ss = new Texture2D( Screen.width, Screen.height, TextureFormat.RGB24, false );
	ss.ReadPixels( new Rect( 0, 0, Screen.width, Screen.height ), 0, 0 );
	ss.Apply();

	// Save the screenshot to Gallery/Photos
	Debug.Log( "Permission result: " + NativeGallery.SaveImageToGallery( ss, "Christmas tree AR+", "Photo {0}.png" ) );
	
	// To avoid memory leaks
	Destroy( ss );
}
}
