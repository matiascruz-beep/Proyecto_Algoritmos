/*
 * Created by SharpDevelop.
 * User: Matias Escobar
 * Date: 4/5/2025
 * Time: 18:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TPFinal
{
	/// <summary>
	/// Description of obrero.
	/// </summary>
	public class obrero
	{
		
			protected string nombre;
			protected string apellido;
			protected string dni;
			protected string legajo;
			protected double sueldo;
			protected string cargo;
			
			
			public obrero (string n, string a, string d, string lej, double suel, string car)
			{
				nombre = n;
				apellido = a;
				dni = d;
				legajo = lej;
				sueldo = suel;
				cargo = car;
			
			}
			
			public string Nombre{
				set{nombre = value;}
				get{return nombre;}
			}
			
			
			
			public string Apellido{
				set{apellido = value;}
				get{return apellido;}
				
			}
			
			public string Dni{
				set{dni = value;}
				get{return dni;}
				
			}
			
			public string Legajo{
				set{legajo = value;}
				get{return legajo;}
				
			}
			
			public double Sueldo{
				set{sueldo = value;}
				get{return sueldo;}
				
			}
			
			public string Cargo{
				set{cargo = value;}
				get{return cargo;}
				
			}
			
		
		}
	}

