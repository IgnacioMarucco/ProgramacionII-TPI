﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CIneData.Models;

public partial class Funcione
{
    public int IdFuncion { get; set; }

    public int? IdPelicula { get; set; }

    public int? IdSala { get; set; }

    public DateTime? Horario { get; set; }

    public bool? Subtitulada { get; set; }

    public decimal? PrecioActual { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    [JsonIgnore]
    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual Pelicula IdPeliculaNavigation { get; set; }

    public virtual Sala IdSalaNavigation { get; set; }
}