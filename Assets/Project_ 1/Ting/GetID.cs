using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetID : MonoBehaviour {
public string installerName;
public string identifier;
public string productName;
	
	void Start ()
	{
	installerName = (Application.installerName);
	identifier = (Application.identifier);
	productName = (Application.productName);
	}
	
	
}
