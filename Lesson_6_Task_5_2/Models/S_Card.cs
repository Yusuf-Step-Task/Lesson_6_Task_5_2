using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class S_Card
{
    public int Id { get; set; }
    public int Id_Student { get; set; }
    public int Id_Book { get; set; }
    public int Id_Lib { get; set; }
    
    public DateTime DateOut { get; set; }
    public DateTime? DateIn { get; set; }
    // Np
    public Student Student { get; set; }
    public Book Book { get; set; }
    public Lib Lib { get; set; }
}