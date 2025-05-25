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
using System.Collections.Generic;
namespace TPFinal
{
	class Program
	{
		public static void Main(string[] args)
		{	
			//CREANDO LA EMPRESA Y LOS GRUPOS
			empresa NuevaEmpresa = new empresa ("AMD");
			grupoDeObreros grupo1 = new grupoDeObreros("cod1","grupo1");
			grupoDeObreros grupo2 = new grupoDeObreros("cod2","grupo2");
			grupoDeObreros grupo3 = new grupoDeObreros("cod3","grupo3");
			grupoDeObreros grupo4 = new grupoDeObreros("cod4","grupo4");
			grupoDeObreros grupo5 = new grupoDeObreros("cod5","grupo5");
			grupoDeObreros grupo6 = new grupoDeObreros("cod6","grupo6");
			grupoDeObreros grupo7 = new grupoDeObreros("cod7","grupo7");
			grupoDeObreros grupo8 = new grupoDeObreros("cod8","grupo8");
			
			//creo un jefe
			/*public jefe (double bon, string n, string a, string d, string lej, double suel, string car , grupoDeObreros grupoDesig)*/
			
			jefe jefe1 = new jefe(100000,"matias","cruz","41208008","112",20000000,"ingeniero",grupo1);
			jefe jefe2 = new jefe(100000,"Juan","Perez","87687676","43",678000,"Arquitecto",grupo4);
			jefe jefe3 = new jefe(100000,"piuque","carteau","546765","88",1320000,"Ingeniera",grupo2);
			jefe jefe4 = new jefe(100000,"ayelen","carteau","768686","323",786000,"Ingeniera",grupo7);
			jefe jefe5 = new jefe(100000,"agustin","cruz","2134553","423",2650000,"Ingeniero",grupo8);
			jefe jefe6 = new jefe(100000,"carlitos","contreras","465656","999",2650000,"Arquitecto",grupo2);
			
			
			//Creo un obrero
			/*obrero (string n, string a, string d, string lej, double suel, string car)*/
			obrero ob1 = new obrero("Mateo","espindola","324673264","09",453434444, "albañil");
			NuevaEmpresa.AgregarObrero(ob1);
			grupo1.AgregarObrero(ob1);
			
			grupo1.setJefe_asignado(jefe1);
			grupo4.setJefe_asignado(jefe2);
			grupo2.setJefe_asignado(jefe3);
			grupo7.setJefe_asignado(jefe4);
			grupo8.setJefe_asignado(jefe5);
			grupo2.setJefe_asignado(jefe6);
			
			NuevaEmpresa.AgregarObrero(jefe1);
			NuevaEmpresa.AgregarObrero(jefe2);
			NuevaEmpresa.AgregarObrero(jefe3);
			NuevaEmpresa.AgregarObrero(jefe4);
			NuevaEmpresa.AgregarObrero(jefe5);
			NuevaEmpresa.AgregarObrero(jefe6);

			
			//CREANDO LAS OBRAS SIN JEFES NI GRUPOS 
			/*obra (string nom,string dnPro,string codigo,double co,string tipo_ob,jefe eljefe)*/
			obra Electricidad  = new obra ("martin","121",1,1300100,"Electricidad",jefe1);
			obra construccion = new obra ("salomon","155",2,1200100, "Construccion",jefe2);
			obra remodelacion = new obra ("Mauricio","399",3,1200100,"Remodelacion",jefe3);
			obra pintura = new obra ("Mario","455",2,1200100,"Pintura",jefe4);
			
			jefe1.setObra(Electricidad);
			jefe2.setObra(construccion);
			jefe3.setObra(remodelacion);
			jefe4.setObra(pintura);
			
			
			//Agrego las obras a la lista de obras en ejecucion (MC)
			NuevaEmpresa.agregar_obra_en_ejecucion(Electricidad);
			NuevaEmpresa.agregar_obra_en_ejecucion(construccion);
			NuevaEmpresa.agregar_obra_en_ejecucion(remodelacion);
			NuevaEmpresa.agregar_obra_en_ejecucion(pintura);
			
			//AGREGANDO LAS OBRAS A LA EMPRESA
			NuevaEmpresa.AgregarObra(Electricidad);
			NuevaEmpresa.AgregarObra(construccion);
			NuevaEmpresa.AgregarObra(remodelacion);
			NuevaEmpresa.AgregarObra(pintura);
			
			
			//AGREGANDO LOS GRUPOS A LA LISTA "GRUPOS"	
			/*ArrayList grupos = new ArrayList ();
			grupos.Add(grupo1);
			grupos.Add(grupo2);
			grupos.Add(grupo3);
			grupos.Add(grupo4);
			grupos.Add(grupo5);
			grupos.Add(grupo6);
			grupos.Add(grupo7);
			grupos.Add(grupo8);*/
			NuevaEmpresa.agregar_grupo_a_lista(grupo1);
			NuevaEmpresa.agregar_grupo_a_lista(grupo2);
			NuevaEmpresa.agregar_grupo_a_lista(grupo3);
			NuevaEmpresa.agregar_grupo_a_lista(grupo4);
			NuevaEmpresa.agregar_grupo_a_lista(grupo5);
			NuevaEmpresa.agregar_grupo_a_lista(grupo6);
			NuevaEmpresa.agregar_grupo_a_lista(grupo7);
			NuevaEmpresa.agregar_grupo_a_lista(grupo8);
			
			
			
			
			
			// LLAMANDO A LA FUNCION MENU Y CREANDO EL SWITCH PARA EL MENU PRINCIPAL
			menu(NuevaEmpresa);
			string salir ="0";
			salir = Console.ReadLine();
			while (salir!="") {
				switch (salir) {	
					case "a":
						Console.Clear();
						//CREA UN OBRERO, LO AGREGA A LA EMPRESA Y LE ASIGNA UN GRUPO
						obrero obreroAux = crearObrero(NuevaEmpresa);
						NuevaEmpresa.AgregarObrero(obreroAux);
						Console.WriteLine("Obrero agregado a la empresa con éxito");
						Console.WriteLine("¿A qué grupo quiere designar el empleado?\n");
						List<grupoDeObreros> lista1 = NuevaEmpresa.devoler_lista_grupos();
						for(int i=0 ; i< lista1.Count ; i++){
							Console.WriteLine(lista1[i].Nombre);
							}
						Console.Write("\nOpcion (sólo el número de grupo): ");
						string opc = Console.ReadLine();
						
						for(int i=0 ; i< lista1.Count ; i++){
							if(lista1[i].Nombre[5] == char.Parse(opc)){lista1[i].AgregarObrero(obreroAux);}
							}
						Console.WriteLine("Obrero agregado con exito.\n");
						Console.WriteLine("Presione una tecla para continuar...");
						Console.ReadKey(true);
						break;
						
					case "b":
						Console.Clear();
						//ELIMINA UN EMPLEADO
						List<obrero> verObreros = NuevaEmpresa.listaObrero();
						// Encabezado
						Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-10} {4,-10} {5,-15}", 
                      	"Nombre", "Apellido", "DNI", "Legajo", "Sueldo", "Cargo");
   						Console.WriteLine(new string('-', 90)); // Línea separadora
							foreach (obrero elemen in verObreros) {
   							if(elemen.GetType() == typeof(obrero)){
							Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-10} {4,-10:F2} {5,-15}\n", elemen.Nombre, elemen.Apellido, elemen.Dni, elemen.Legajo, elemen.Sueldo, elemen.Cargo);
							}
   						}
						
						Console.Write("Ingrese el legajo: ");
						string empleadoELimar = Console.ReadLine();
						eliminarelobrero(empleadoELimar,NuevaEmpresa);
						
						Console.WriteLine("Presione una tecla para continuar...");
						Console.ReadKey(true);
						break;
					
				   	case "c":
						Console.Clear();
						crearJefe(NuevaEmpresa);
						Console.WriteLine("Presione una tecla para continuar...");
						Console.ReadKey(true);
						break;
					case "d":
						subMenu();
						string subMenu1 = "0";
						subMenu1 = Console.ReadLine();
						while (subMenu1!="") {
							switch (subMenu1) {
									
								case "1":
									//Muestra todos los obreros (linea 331)
									muestra_Obreros(NuevaEmpresa);
									break;
								case "2":
									//Muestra las obras en ejecucion
									Muestra_Obras_Existentes(NuevaEmpresa);
									break;
								case "3":
									//Muestra los jefes junto con su obra asignada (linea 320)
									muestra_Jefes(NuevaEmpresa);
									break;
								case "4":
									//Porcentaje de obras en remodelacion sin finalizar
									porcentaje_obras_sinFinalizar(NuevaEmpresa);
									break;	
								case "5":
									//vuelve al menu pricipal
									subMenu1="";
									Console.Clear();
									continue;
							}
							Console.Write("Presione una tecla para continuar...");
							Console.ReadKey(true);
							Console.Clear();
							subMenu();
							subMenu1 = Console.ReadLine();	
						}
						break;
	
					case "e":
						Console.Clear();
						//Modificamos el estado de avance de la obra
						Modifica_Estado_Avance(NuevaEmpresa);
						Console.WriteLine("Presione una tecla para continuar...");
						Console.ReadKey(true);
						break;	
					case "f":
						Console.Clear();
						dar_baja_a_jefe(NuevaEmpresa);
						Console.WriteLine("Presione una tecla para continuar...");
						Console.ReadKey(true);
						break;	
					case "g":
						crearObra(NuevaEmpresa);
						break;
				}
				menu(NuevaEmpresa);
				salir = Console.ReadLine();
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		// MENU PRINCIPAL
		static void menu(empresa nuevaEmpresa){
			Console.Clear();
			Console.WriteLine("¡Bienvenido a la Empresa {0}! \n\nSeleccione una opcion:\n", nuevaEmpresa.Nombre);
			Console.WriteLine("a - Contratar un obrero nuevo");
			Console.WriteLine("b - Eliminar un obrero");
			Console.WriteLine("c - Contratar a un jefe de obra");
			Console.WriteLine("d - Submenú de impresión");
			Console.WriteLine("e - Modificar el estado de avance de una obra");
			Console.WriteLine("f - Dar de baja a un jefe");
			Console.WriteLine("g - Crear una obra\n");
			Console.WriteLine("Para salir presione enter\n");
			Console.Write("Opción: ");
		}
		
		
		//CREA EL OBRERO DE LA OPCION A DEL MENU PRINCIPAL
		static obrero crearObrero(empresa emp){
			Console.WriteLine("Datos del Obrero:");
			Console.Write("Nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Apellido: ");
			string apellido = Console.ReadLine();
			Console.Write("DNI (sin puntos): ");
			string dni = Console.ReadLine();
			
			string legajo = verifica_Legajos(emp);

			Console.Write("Sueldo destinado: ");
			double sueldo =  double.Parse(Console.ReadLine());
			Console.Write("Cargo que ocupa: ");
			string cargo = Console.ReadLine();
			
			obrero NuevoObrero = new obrero(nombre,apellido,dni,legajo,sueldo,cargo);
			return NuevoObrero;
		}
	
		
	// LA FUNCION SE UTILIZA EN LA OPCION "B" DEL MAIN
	static void eliminarelobrero(string legajo, empresa laempresa){
		List<obrero> listObrero = laempresa.listaObrero();
		for (int i = 0; i < listObrero.Count; i++) {
			obrero ob = (obrero)listObrero[i];
			if (legajo == ob.Legajo) {
				laempresa.EliminarObrero(ob);
				Console.WriteLine("\nEliminado con exito de la empresa\n");
				List<grupoDeObreros> lista = laempresa.devoler_lista_grupos();
				foreach(grupoDeObreros grupo in lista){
					if(grupo.ExisteObrero(ob) == true){
						grupo.EliminarObrero(ob);
						Console.WriteLine("Obrero {0} {1} eliminado del {2}\n",ob.Nombre,ob.Apellido,grupo.Nombre);
				 }
			  }
		   }
		}
	 }
		
		
		
	static string verifica_Legajos(empresa emp){
		List<obrero> lista_Ob = emp.devolver_lista_obreros();
		List<string> legajos = new List<string>();
		Console.Write("Legajo: ");
		string legajo1 = Console.ReadLine();
		foreach (obrero ob in lista_Ob){
			string legajo2 = ob.Legajo;
			if(legajo1 == legajo2){
			while(legajo1 == legajo2){
				Console.Clear();
				Console.WriteLine("\nLegajo duplicado, ingrese nuevamente: \n");
				Console.Write("Legajo: ");
				legajo1 = Console.ReadLine();
			}
		}
	}
			return legajo1;
}
	//Funcion Submenu 
	static void subMenu (){
		Console.Clear();
		Console.WriteLine("\nSubmenu\n");
		Console.WriteLine("1 - Lista de Obreros");
		Console.WriteLine("2 - Obras en Ejecucion");
		Console.WriteLine("3 - Jefes");
		Console.WriteLine("4 - Porcentajes de Obras en remodelacion sin finalizar");
		Console.WriteLine("5 - Volver al menu principal");
		Console.Write("\nOpcion: ");
	}
	
	
	//Creo la funcion para modificar el estado de avanca de la obra (MC)
	static void Modifica_Estado_Avance(empresa NuevaEmpresa){
		Console.WriteLine("Seleccione la obra\n");
		List<obra> lista = NuevaEmpresa.devolver_lista_obras_ejecucion();
		int contador = 0;
		foreach (obra ob in lista){
			contador++;
			Console.WriteLine(contador + " " + ob.tipo_Ob + "\n");
		}
		Console.Write("Opcion: ");
		try{
			string opcion = Console.ReadLine();
			Console.WriteLine("El estado de avance actual de la obra de " + lista[int.Parse(opcion)-1].tipo_Ob +
				                  " Es del: " + lista[int.Parse(opcion)-1].porcentajeAvance+"%\n");
			Console.Write("\nIngrese el nuevo porcentaje de avance: ");
			double nuevo_porcentaje = double.Parse(Console.ReadLine());
		
		
		
		if(nuevo_porcentaje == 100){
			obra obSeleccionada = lista[int.Parse(opcion) - 1];
			Console.WriteLine("Obra de " +obSeleccionada.tipo_Ob + " finalizada.\n");
			NuevaEmpresa.AgregarObraFinalizada(obSeleccionada);
			//Tengo que desvincular el jefe de la obra y ponerlo como disponible
			List<jefe> lista_jefes =  devolver_lista_jefes(NuevaEmpresa);
			foreach (jefe j in lista_jefes){
				if(j.getObra() == obSeleccionada){
					j.setObra(null);
				}
			}
			
			NuevaEmpresa.eliminar_obra_en_ejecucion(obSeleccionada);
			Console.WriteLine("Obra eliminada de la lista de obras en ejecución\n");
			Console.WriteLine("Cantidad de obras en ejecucion: " + NuevaEmpresa.cantidad_obras_en_ejecucion());
		}else{
			lista[int.Parse(opcion)-1].porcentajeAvance = nuevo_porcentaje;
			Console.WriteLine("\nPorcentaje guardado exitosamente!");
			//Console.WriteLine("Nuevo porcentaje: " + lista[int.Parse(opcion)-1].porcentajeAvance);
		}
		}
		catch(IndexOutOfRangeException){Console.WriteLine("Indice invalido, intente nuevamente");}
		catch(FormatException){Console.WriteLine("Debe ingresar un número");}
		catch(ArgumentOutOfRangeException){Console.WriteLine("Indice invalido, intente Nuevamente");}
		}
	
	static void porcentaje_obras_sinFinalizar(empresa NuevaEmpresa){
		int cantidad_obras = NuevaEmpresa.CantidadObra();
		int cantidad_obras_en_ejecucion = NuevaEmpresa.cantidad_obras_en_ejecucion();
		float porcentaje = ((float)cantidad_obras_en_ejecucion / cantidad_obras) * 100;
			
		Console.WriteLine("Porcentaje de obras sin finalizar: {0}%", porcentaje );
	}
	
	
		//CREA UN JEFE, ESTA FUNCION SE UTILIZA EN EL MAIN EN LA OPCION "C" MAIN
	static void crearJefe (empresa NuevaEmpresa){
			List<obra> lista = NuevaEmpresa.devolver_lista_obras_ejecucion();
			try{
				List<grupoDeObreros> lista2 = devuelve_grupos_sin_jefe(NuevaEmpresa);
			
			if(lista2.Count == 0){
				throw new sinGrupos();
			}
				
			
			obrero ab = crearObrero(NuevaEmpresa);
			Console.Write("Bonificacion(en pesos): ");
			double boni = double.Parse(Console.ReadLine());
				
			Console.WriteLine("\n Elija el grupo a designar: \n");

			for (int i = 0 ; i<lista2.Count ; i++){
				Console.WriteLine("{0} - {1}",(i+1),lista2[i].Nombre);
			}
			
			bool condicion = true;
			while(condicion){
				try{
				Console.Write("\nOpcion: ");
				int opcion2 = int.Parse(Console.ReadLine());
				grupoDeObreros grupoDesig = lista2[opcion2-1];
				jefe nuevoJefe = new jefe (boni, ab.Nombre ,ab.Apellido, ab.Dni,ab.Legajo, ab.Sueldo, ab.Cargo, grupoDesig);
				NuevaEmpresa.AgregarObrero(nuevoJefe);
				lista2[opcion2-1].setJefe_asignado(nuevoJefe);
				Console.WriteLine("El jefe se asigno el grupo " + lista2[opcion2-1].Nombre[5] );
				Console.WriteLine("el grupo "+ lista2[opcion2-1].Nombre[5] + " tiene como jefe: " + lista2[opcion2-1].getJefe_asignado().Nombre);
				condicion = false;
			}catch(ArgumentOutOfRangeException){Console.WriteLine("\nOpcion invalida, intente nuevamente");}
			catch(FormatException){Console.WriteLine("Debe ingresar un numero");}
			}
			}catch(sinGrupos){}
			
		}
	
	//La uso en crearObra() (mc)
	static List<grupoDeObreros> devuelve_grupos_sin_jefe(empresa NuevaEmpresa){
		List<grupoDeObreros> lista = NuevaEmpresa.devoler_lista_grupos();
		List<grupoDeObreros> lista_grupos_sin_jefe = new List<grupoDeObreros>();
		foreach (grupoDeObreros grupo in lista){
			if(grupo.getJefe_asignado() == null){lista_grupos_sin_jefe.Add(grupo);}
		}
		return lista_grupos_sin_jefe;
	}
	
	
	
	//Para que el main siempre nos tire obras existentes (porque puede haber finalizado alguna cuando su estado de avance es del 100%)
	 static void Muestra_Obras_Existentes(empresa NuevaEmpresa){
		List<obra> lista = NuevaEmpresa.devolver_lista_obras_ejecucion();
		int contador = 0;
		
		foreach (obra ob in lista){
			contador++;
			Console.WriteLine("\n"+contador + " - " + ob.tipo_Ob + "\n");
		}
	}
	
	//Muestra lista de jefes
	static void muestra_Jefes(empresa nuevaEmpresa){
		List<obrero> lista = nuevaEmpresa.devolver_lista_obreros();
		Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-20} {5,-15} {6,-15}", 
                 "Nombre", "Apellido", "DNI", "Legajo", "Bonificacion", "Cargo", "Sueldo");
   		Console.WriteLine(new string('-', 120)); // Línea separadora
   		for(int i=0 ; i< lista.Count ; i++) {
   			if(lista[i].GetType() == typeof(jefe)){
   				jefe j = (jefe)lista[i];
			Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-20:F2} {5,-15} {6,-15:F2}\n", j.Nombre,j.Apellido,j.Dni,j.Legajo,j.Sueldo,j.Cargo, j.Bonificacion);
			}
   		}
	}
	
	
	
	//Muestra todos los obreros
	static void muestra_Obreros(empresa NuevaEmpresa){
		
		List<obrero> verObreros = NuevaEmpresa.listaObrero();
		// Encabezado
		Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-10} {4,-10} {5,-15}", 
                      "Nombre", "Apellido", "DNI", "Legajo", "Sueldo", "Cargo");
   		Console.WriteLine(new string('-', 90)); // Línea separadora
		foreach (obrero elemen in verObreros) {
   			if(elemen.GetType() == typeof(obrero)){
			Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-10} {4,-10:F2} {5,-15}\n", elemen.Nombre, elemen.Apellido, elemen.Dni, elemen.Legajo, elemen.Sueldo, elemen.Cargo);
			}
   		  }
		}
	
	static List<jefe> devolver_lista_jefes(empresa nuevaEmpresa){
		List<jefe> lista_jefes = new List<jefe>();
		List<obrero> lista_obreros = nuevaEmpresa.devolver_lista_obreros();
		foreach(obrero ob in lista_obreros){
			if(ob.GetType() == typeof(jefe)){
				jefe j = (jefe)ob;
				lista_jefes.Add((jefe)ob);
			}
		}
		return lista_jefes;
	}
	
	/*-	Dar de baja a un jefe (se elimina de la empresa, se desvincula de la obra y se libera el grupo de obreros asignado)*/
	static void dar_baja_a_jefe(empresa NuevaEmpresa){
		Console.Write("Lista de jefes: \n");
		List<jefe> lista = devolver_lista_jefes(NuevaEmpresa);
		
		// Encabezado con formato fijo: 15 caracteres para cada columna
    	Console.WriteLine("{0,-15} {1,-15} {2,-10}", "Nombre", "Apellido", "Legajo");
    	Console.WriteLine(new string('-', 50)); // Línea separadora
		//Muestro los jefes con nombre apellidop y legajo
		for(int i = 0 ; i < lista.Count ; i++){
		jefe j = lista[i];
		
		Console.WriteLine("{0,-15} {1,-15} {2,-10}\n",j.Nombre, j.Apellido, j.Legajo);
		}
		Console.Write("\nIngrese el legajo del jefe: ");
		string legajo = Console.ReadLine();
		for(int i=0 ; i< lista.Count ; i++){
		// Verifica que la obra tenga jefe antes de acceder a su Legajo
		if (lista[i].Legajo == legajo)
		{
			jefe jefe_A_eliminar = lista[i];

			/*// Desasignás el jefe de la obra
			lista[i].JefeDeObra = null;*/
				
			//libero el grupo
			lista[i].getGrupo().setJefe_asignado(null);
			

			// Eliminás al jefe de la empresa
			NuevaEmpresa.EliminarObrero(jefe_A_eliminar);

			Console.WriteLine("Jefe eliminado con éxito.");
			return; // Terminás después de encontrar y eliminar
				}
			}
		}
		
	static void crearObra(empresa NuevaEmpresa){
		Console.Clear();
		Console.WriteLine("Datos de la obra: \n");
		
		Console.Write("Nombre de la obra: ");
		string NombreObra = Console.ReadLine();
		
		Console.Write("Nombre del propietario: ");
		string Nombre_Propietario = Console.ReadLine();
		
		Console.Write("DNI del propietario (sin puntos): ");
		string Dni_propietario = Console.ReadLine();
		
		//creo el codigo interno 
		int codigo_interno = new Random().Next(1,1000000);
		
		Console.Write("Costo: ");
		
		double costo = double.Parse(Console.ReadLine());
		int opcion;
		List<jefe> lista = devuelve_lista_jefes_disponibles(NuevaEmpresa);
		//--------------------------
		if(lista.Count == 0){
			Console.Write("\nNo hay jefes disponibles, ¿Desea crear uno ahora?(s/n): ");
			string opcion2 = Console.ReadLine().ToLower();
			
			if(opcion2 == "s"){
				crearJefe(NuevaEmpresa);
				lista = devuelve_lista_jefes_disponibles(NuevaEmpresa);
			}else{
				Console.WriteLine("\nNo se puede crear una obra sin un jefe, Intente nuevamente");
				return;
			}
		}
		Console.WriteLine("\nJefes diponibles:\n");
		muestra_jefes_disponibles(NuevaEmpresa);
		Console.Write("\nSeleccione un jefe: ");
			
		try{
			opcion = int.Parse(Console.ReadLine());
			
			jefe jefe_asignado = lista[opcion-1];
			
			/*obra (string nom,string dnPro,string codigo,double co,string tipo_ob,jefe eljefe)*/
			obra ob = new obra(Nombre_Propietario,Dni_propietario,codigo_interno,costo,NombreObra,jefe_asignado);
			NuevaEmpresa.AgregarObra(ob);
			jefe_asignado.setObra(ob);
			NuevaEmpresa.agregar_obra_en_ejecucion(ob);
			Console.WriteLine("\nObra creada con exito");
			
		}
		catch(ArgumentOutOfRangeException) 
			{
			Console.WriteLine("\nOpcion invalida, intente nuevamente");
			}
		catch(FormatException){
			Console.WriteLine("\nDebe ingresar un numero valido");
		}
		
		Console.ReadKey(true);
		
	}
	
	static List<jefe> devuelve_lista_jefes_disponibles(empresa NuevaEmpresa){
		List<jefe> jefes_disponibles = new List<jefe>();
		List<obrero> lista_obreros = NuevaEmpresa.devolver_lista_obreros();
		foreach(obrero ob in lista_obreros){
			if(ob.GetType() == typeof(jefe)){
				jefe j = (jefe)ob;
				if(j.getObra() == null)
				jefes_disponibles.Add((jefe)ob);
			}
		}
		return jefes_disponibles;
	}
	
	static void muestra_jefes_disponibles(empresa NuevaEmpresa){
		int contador = 0;
		List<jefe>lista_obreros = devuelve_lista_jefes_disponibles(NuevaEmpresa);
		try{
			foreach(obrero ob in lista_obreros){
			contador++;
			if(ob.GetType() == typeof(jefe)){
				Console.WriteLine("{0} - {1} {2}\n", contador, ob.Nombre, ob.Apellido);
			 }
		  }
			
		}catch(IndexOutOfRangeException){Console.WriteLine("Opcion erronea");}
		
     }
  }
}