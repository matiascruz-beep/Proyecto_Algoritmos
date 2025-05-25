/*
 * Created by SharpDevelop.
 * User: Matias Escobar
 * Date: 4/5/2025
 * Time: 18:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace TPFinal
{
	/// <summary>
	/// Description of empresa.
	/// </summary>
	public class empresa
	{
			private string nombre; 
			private List<obra> listaObras;
			private List<obrero> listaObreros;
			private List<obra> listaObrasFinalizadas;
			private List<grupoDeObreros> lista_De_grupos;
			private List<obra> lista_obras_en_ejecucion;
			
			
			
			public empresa (string nom){
				nombre = nom;
				listaObras = new List<obra>();
				listaObreros = new List<obrero>();
				listaObrasFinalizadas = new List<obra>();
				//grupos_de_obreros = new List<obrero>();
				lista_obras_en_ejecucion = new List<obra>();
				lista_De_grupos = new List<grupoDeObreros>();
			}
			
			public string  Nombre{
				set { nombre=value;}
				get { return nombre;}
			}
			
			
			//metodos para el obrero 
			
			public void AgregarObrero (obrero elObrero){
				
				listaObreros.Add(elObrero);
				
			}
			
			public void EliminarObrero (obrero elObrero){
				
			listaObreros.Remove(elObrero);
				
			}
			public bool ExisteObrero (obrero elObrero){
				
				return listaObreros.Contains(elObrero);
				
			}
			public List<obrero> listaObrero (){
				
				return listaObreros;
			}
				
			public int CantidadObrero (obrero elObrero){
				 return	listaObreros.Count;
				
			}
			public obrero VerObrero(int i){
				return	(obrero) listaObreros[i];
				}
			
			public List<obrero> devolver_lista_obreros(){
				return listaObreros;
			}
			//Métodos para la obra
			
			public void AgregarObra(obra laObra){
				
				listaObras.Add( laObra);
				
			}
			
			public void EliminarObra (obra  laObra){
				
				listaObras.Remove( laObra);
				
			}
			public bool ExisteObra (obra laObra){
				
				return listaObras.Contains( laObra);
				
			}
			public List<obra> listaObra (){
				
				return listaObras;
			}
				
			public int CantidadObra (){
				 return	listaObras.Count;
				
			}
			public obra VerObra(int i){
				return (obra)listaObras[i];
				}
			
			//Agrego metodo para devolver lista de obras (MC)
			public List<obra> devoler_lista_obras(){
				return listaObras;
			}
			
			
			// Métodos para las obras finalizadas
			public void AgregarObraFinalizada(obra laObra){
				
				listaObrasFinalizadas.Add( laObra);
				
			}
			
			public void EliminarObraFinalizada (obra  laObra){
				
				listaObrasFinalizadas.Remove( laObra);
				
			}
			public bool ExisteObraFinalizada (obra laObra){
				
				return listaObrasFinalizadas.Contains(laObra);
				
			}
			public List<obra> listaObraFinalizada (){
				
				return listaObrasFinalizadas;
			}
				
			public int CantidadObraFinalizada (){
				 return	listaObrasFinalizadas.Count;
				
			}
			public obra VerObraFinalizadas(int i){
				return (obra)listaObrasFinalizadas[i];
				}
			
			//metodos para lista_obras_en_ejecucion (MC)
			
			public void agregar_obra_en_ejecucion(obra ob){
				lista_obras_en_ejecucion.Add(ob);
			}
			public void eliminar_obra_en_ejecucion(obra ob){
				lista_obras_en_ejecucion.Remove(ob);
			}
			public int cantidad_obras_en_ejecucion(){
				return lista_obras_en_ejecucion.Count;
			}
			public List<obra> devolver_lista_obras_ejecucion(){
				
				return lista_obras_en_ejecucion;
			}
			
			//metodos de la lista de lista_De_grupos
			public void agregar_grupo_a_lista(grupoDeObreros grupo){
				lista_De_grupos.Add(grupo);
			}
			public void eliminar_grupo_de_lista(grupoDeObreros grupo){
				lista_De_grupos.Remove(grupo);
			}
			public int cantidad_De_grupos(){
				return lista_De_grupos.Count;
			}
			public bool Existe_grupo( grupoDeObreros grupo){
				return lista_De_grupos.Contains(grupo);
			}
			public List<grupoDeObreros> devoler_lista_grupos(){
				return lista_De_grupos;
			}
			
			
		}
	}

