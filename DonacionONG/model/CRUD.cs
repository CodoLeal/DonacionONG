using System;
using System.Collections.Generic;
using System.Text;

namespace DonacionONG.model
{
    internal interface CRUD<T>
    {
        void insertar(T t);
        List<T> listar();
        void actualizar(T t);
        void eliminar(int id);
    }
}
