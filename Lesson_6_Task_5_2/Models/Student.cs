using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id_Group { get; set; }
    public int Term { get; set; }
    // Np
    public Group Group { get; set; }
    // Relationship    
    public ICollection<S_Card> S_Cards { get; set; }
}
