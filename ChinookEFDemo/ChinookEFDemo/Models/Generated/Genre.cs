﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChinookEFDemo.Models;

[Table("genres")]
public partial class Genre
{
    [Key]
    public long GenreId { get; set; }

    [Column(TypeName = "NVARCHAR(120)")]
    public string? Name { get; set; }

    [InverseProperty("Genre")]
    public virtual ICollection<Track> Tracks { get; } = new List<Track>();
}
