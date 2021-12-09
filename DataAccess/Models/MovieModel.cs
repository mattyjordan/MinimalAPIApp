using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class MovieModel
{
    public int Id { get; set; }
    public string? MovieName { get; set; }
    public short ReleaseYear { get; set; }
}
