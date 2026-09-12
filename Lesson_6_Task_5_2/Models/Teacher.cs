using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Teacher
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id_Dep { get; set; }
    // Np
    public Department Department { get; set; }
    // RElatioonship
    public ICollection<T_Card> T_Cards { get; set; }
}
