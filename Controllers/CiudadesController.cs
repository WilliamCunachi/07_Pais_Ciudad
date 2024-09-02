using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_Pais_Ciudad.Model;

namespace _07_Pais_Ciudad.Controllers
{
    internal class CiudadesController
    {
        CiudadesModel _ciudadesModel = new CiudadesModel();
        public DataTable todosconrelacion()
        {
            return _ciudadesModel.todosconrelacion();
        }
       
        }
    }


