using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Id_Faculty { get; set; }
    // Np
    public Faculty Faculty { get; set; }
    //Relationship
    public ICollection<Student> Students { get; set; }
}
