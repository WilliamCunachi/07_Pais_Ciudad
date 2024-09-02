using _07_Pais_Ciudad.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Pais_Ciudad.Controllers
{
    internal class PaisesControllers
    {
        PaisModel _PaisModel = new PaisModel();

        public DataTable todos()
        {

            return _PaisModel.todos();

        }
    }
}