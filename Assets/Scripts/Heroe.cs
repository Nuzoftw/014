using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe
    //Este script le da la posición al Heroe, le agrega el FPSMove y el FPSAim para contrarlo.
{
	public Heroe() 
	{
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		go.GetComponent<Renderer>().material.color = Color.red;
		Vector3 pos = new Vector3 (Random.Range(-10, 10), 0, Random.Range(-10, 10)); 
		go.transform.position = pos; 
		go.AddComponent<FPSMove>();    
		Camera.main.gameObject.transform.localPosition = go.transform.position; 
		Camera.main.transform.SetParent(go.transform);                          
		Camera.main.gameObject.AddComponent<FPSAim>(); 
	}
}