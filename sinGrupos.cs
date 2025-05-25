
 /** Created by SharpDevelop.
 * User: Matias Escobar
 * Date: 8/5/2025
 * Time: 20:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TPFinal
{
	/// <summary>
	/// Description of cuposInsuficientes.
	/// </summary>
	public class sinGrupos : Exception
	{
		public sinGrupos()
		{
			Console.WriteLine("No hay grupos para designar");
		}
	}
}
