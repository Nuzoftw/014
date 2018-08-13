using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie 
    // Este script es el que crea las primitivas de los zombies, les da nombre, color y les da
    // una posición random en la escena.
{
	string color;
	public Zombie ()
	{
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube);     
		Vector3 pos = new Vector3 (Random.Range(-10, 10), 0, Random.Range(-10, 10));
		go.transform.position = pos;

		int ColZombie = Random.Range (0, 3);

		if (ColZombie == 0)  
		{
			go.GetComponent<Renderer>().material.color = Color.cyan; 
			color = "cyan"; 
		}
		else if(ColZombie == 1)
		{
			go.GetComponent<Renderer>().material.color = Color.green; 
			color = "green";
		}
		else 
		{
			go.GetComponent<Renderer>().material.color = Color.magenta;
			color = "magenta"; 
		}

		Debug.Log (DarMensaje ());
	}

	public string DarMensaje ()
	{
		string mensaje = "Soy un zombie " + color;
		return mensaje;
	}
}


