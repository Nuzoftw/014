using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
// Este script contiene un caso que toma las instancias de Heroe, Zombie y Ciudadano.
{
    void Start () 
	{
		int personajes = 0; 
		for (int i = 0; i < Random.Range(5, 10); i++)
		{
			switch (personajes)                                                           
			{
				case 0:                                                               
					new Heroe (); 
					break; 
				case 1:                                                                
					new Zombie ();                   
					break;
				case 2:   
					new Ciudadano ();
					break;
				default:                                 
					new Heroe ();
					break;
			}
			personajes = Random.Range(1, 3); 
		}
	}
}
