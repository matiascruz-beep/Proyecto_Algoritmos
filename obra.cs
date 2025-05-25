/*
 * Created by SharpDevelop.
 * User: Matias Escobar
 * Date: 4/5/2025
 * Time: 18:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace TPFinal
{
	/// <summary>
	/// Description of obra.
	/// </summary>
	public class obra
	{
	
			private string nombre;
			private string dniPropietario;
			private int codigoInterno;
			//Agrego el atributo tipoOb (MC)
			private string tipoObra;
			private double costo;
			private jefe jefeDeObra;
			private grupoDeObreros losObrerosDeObra;
			private double porcentajeDeAvance;
			
			
			
			public obra (string nom,string dnPro,int codigo,double co, jefe eljefe, grupoDeObreros losObreros){
				nombre = nom;
				dniPropietario = dnPro;
				codigoInterno = codigo;
				costo = co;
				jefe jefeDeObra = eljefe; 
				losObrerosDeObra = losObreros;
				porcentajeDeAvance = 0;
			}
			
				public obra (string nom,string dnPro,int codigo,double co,string tipo_ob,jefe eljefe){
				nombre = nom;
				dniPropietario = dnPro;
				codigoInterno = codigo;
				costo = co;
				losObrerosDeObra = null;
				tipoObra = tipo_ob;
				porcentajeDeAvance = 0;
				
			}
			
			//creo el metodo para cambiar el estado (MC)
			public string tipo_Ob
			{
				set{tipoObra=value;}
				get{return tipoObra;}
			}
			
			public double porcentajeAvance{
				set{porcentajeDeAvance=value;}
				get{return porcentajeDeAvance;}
			}
			
			public string Nombre
			{
				set{nombre=value;}
				get{return nombre;}
			}
			public string DniPropietario
				{
				set{dniPropietario=value;}
				get{return dniPropietario;}
				}
			
			public int CodigoInterno
			{
				set{codigoInterno=value;}
				get{return codigoInterno;}
			}
				
			public double Costo
			{
				set{costo=value;}
				get{return costo;}
			}
		
			
			public jefe JefeDeObra 
			{
				set{jefeDeObra=value;}
				get{return jefeDeObra;}
			}
			
		
			public grupoDeObreros LosObrerosDeObra 
			{
				set{losObrerosDeObra = value;}
				get{return losObrerosDeObra;}
			}
			
			
		
	}
}
