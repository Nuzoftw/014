using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano
    // Este script se encarga de darle un nombre, una edad y una posición random al ciudadano. 
    // Además que le permite al ciudadano escribir en un mensaje su identidad.
{
	public int age;
	string nombre;

	string [] names = new string[]
	{
		"Norfi", "Sindy", "Paola", "Nuzo", "Alirio", "Ismael", "Celeste", "Sara", "Mónica",
        "Kelly", "Santiago", "Jacobo", "Michael", "Anthua", "Nayibi", "Cony", "Margot", "Sebastián", "Nasly",
        "Caca"
	};

	public Ciudadano()
	{
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube);    
		Vector3 pos = new Vector3 (Random.Range(-10, 10), 0, Random.Range(-10, 10)); 
		go.transform.position = pos; 
		nombre = names [Random.Range(0, names.Length)]; 
		age = Random.Range (15, 101);

		Debug.Log (DarMensaje ()); 
	}
		
	string DarMensaje () 
	{
		string mensaje = "Mi nombre es " + nombre + " y tengo " + age + " años."; 
		return mensaje; 
	}
}

