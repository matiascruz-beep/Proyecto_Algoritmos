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
		
	
			double bonificacion;
						
			private grupoDeObreros grupoAsignado;
    		private obra obraAsignada;
			
			public jefe (double bon, string n, string a, string d, string lej, double suel, string car,obra obraAsig, grupoDeObreros grupoDesig):base(n,a,d,lej,suel,car)
			{
				bonificacion = bon;
				this.grupoAsignado = grupoDesig;
				this.obraAsignada = obraAsig;
				
			}
			public jefe (double bon, string n, string a, string d, string lej, double suel, string car , grupoDeObreros grupoDesig):base(n,a,d,lej,suel,car)
			{
				bonificacion = bon;
				this.grupoAsignado = grupoDesig;
				this.obraAsignada = null;

			}
			
			public double Bonificacion
			{
			set{bonificacion=value;}
			get{return bonificacion;}
			}
			
			public grupoDeObreros getGrupo(){return grupoAsignado;}
			public obra getObra(){return obraAsignada;}
			public void setObra(obra ob){
				if(ob!= null){this.obraAsignada = ob;}
				else{this.obraAsignada = null;}
			}
			
		}
	}

