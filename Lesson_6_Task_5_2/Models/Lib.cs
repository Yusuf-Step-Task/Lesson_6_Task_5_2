using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Lib
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // Relationship
    public ICollection<S_Card> S_Cards { get; set; }
    public ICollection<T_Card> T_Cards { get; set; }
}
