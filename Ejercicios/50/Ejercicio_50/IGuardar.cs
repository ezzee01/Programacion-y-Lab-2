using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_50
{
    interface IGuardar<T,V>
    {
    bool Guardar(T obj);

    V Leer();
    }
}
