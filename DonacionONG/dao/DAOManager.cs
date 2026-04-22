using System;
using System.Collections.Generic;
using System.Text;

namespace DonacionONG.dao
{
    internal class DAOManager
    {

        private DAODonante daoDonante;
        private DAOProyecto daoProyecto;
        private DAORegistroAporte daoRegistroAporte;

        public DAOManager()
        {
            daoDonante = new DAODonante();
            daoProyecto = new DAOProyecto();
            daoRegistroAporte = new DAORegistroAporte();
        }

        public DAODonante DaoDonante { get => daoDonante; set => daoDonante = value; }
        public DAOProyecto DaoProyecto { get => daoProyecto; set => daoProyecto = value; }
        public DAORegistroAporte DaoRegistroAporte { get => daoRegistroAporte; set => daoRegistroAporte = value; }
    }
}
