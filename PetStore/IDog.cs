using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore;
internal interface IDog {

    string Breed { get; set; }
    int Age { get; set; }
    int Weight { get; set; }
}
