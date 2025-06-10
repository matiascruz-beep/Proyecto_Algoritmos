/*
 * Created by SharpDevelop.
 * User: Matias Escobar
 * Date: 4/5/2025
 * Time: 18:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TPFinal
{
	/// <summary>
	/// Description of jefe.
	/// </summary>
	public class jefe: obrero
	{
		
			string nom_grup;
			double bonificacion;
						
			private grupoDeObreros grupoAsignado;
			
			public jefe (double bon, string n, string a, string d, string lej, double suel, string car,grupoDeObreros grupoDesig):base(n,a,d,lej,suel,car)
			{

				bonificacion = bon;
				this.grupoAsignado = grupoDesig;

				
			}
			
			public jefe (double bon, string n, string a, string d, string lej, double suel, string car,string nombre_grupo ,grupoDeObreros grupoDesig):base(n,a,d,lej,suel,car)
			{
				nom_grup = nombre_grupo;
				bonificacion = bon;
				this.grupoAsignado = grupoDesig;

				
			}
			
			public string Nom_grupo{
				set{nom_grup=value;}
				get{return nom_grup;}
			}
			
			public double Bonificacion
			{
			set{bonificacion=value;}
			get{return bonificacion;}
			}
			
			public grupoDeObreros getGrupo(){return grupoAsignado;}

			
		}
	}

