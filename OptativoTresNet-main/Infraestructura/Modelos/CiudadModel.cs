﻿using System;
namespace Infraestructura.Modelos
{
	public class CiudadModel
	{
		public int idCiu { get; set; }
		public required string Ciudad { get; set; }
		public required string Departamento { get; set; }
		public required string Postal_code { get; set; }

	}
}

