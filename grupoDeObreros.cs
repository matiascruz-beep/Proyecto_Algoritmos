/*
 * Created by SharpDevelop.
 * User: Matias Escobar
 * Date: 6/5/2025
 * Time: 10:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace TPFinal
{
	/// <summary>
	/// Description of grupoDeObreros.
	/// </summary>
	public class grupoDeObreros
	{
		private int codigoObra;
		private List<obrero> obrerosDeObra;
		private string nombreGrupo;
		//private jefe jefeAsignado;
		
		/*public grupoDeObreros(string codigo, jefe jefeDesig,string nombre)
		{
			codigoObra = codigo;
			obrerosDeObra = new List<obrero>();
			jefeAsignado = jefeDesig;
			nombreGrupo = nombre;
			
		}*/
		
		public grupoDeObreros(string nombre){
			nombreGrupo = nombre;
			obrerosDeObra = new List<obrero>();
		}
		
		public grupoDeObreros(int codigo, string nombre)
		{
			CodigoDeObra = codigo;
			obrerosDeObra = new List<obrero>();
			//jefeAsignado = null;
			nombreGrupo = nombre;
		}
		
		//public jefe getJefe_asignado(){return jefeAsignado;}
		
		//public void setJefe_asignado(jefe j){this.jefeAsignado = j;}
		
		public int CodigoDeObra{
			set{codigoObra=value;}
			get{return codigoObra;}
		}
		
		public string Nombre{
			set{nombreGrupo=value;}
			get{return nombreGrupo;}
		}
		
		
		public void AgregarObrero (obrero elObrero){
				
			obrerosDeObra.Add(elObrero);
				
		}
			
		public void EliminarObrero (obrero elObrero){
				
			obrerosDeObra.Remove(elObrero);
				
		}
		
		public bool ExisteObrero (obrero elObrero){
				
			return obrerosDeObra.Contains(elObrero);
				
		}
		
		public List<obrero> listaObrero (){
				
			return obrerosDeObra;
		}
				
		public int CantidadObrero (){
			return	obrerosDeObra.Count;
				
		}
		
		
		public obrero VerObrero(int i){
			return	(obrero)obrerosDeObra[i];
		}
	}
}
