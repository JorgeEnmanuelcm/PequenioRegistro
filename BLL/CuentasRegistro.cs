using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALclass;
using System.Data;

namespace BLL
{
    public class CuentasRegistro
    {
        Conexion conexion = new Conexion();
        public int CuentaId { get; set; }
        public string Descripcion { get; set; }
        public double Balance { get; set; }


        public CuentasRegistro()
        {
            this.CuentaId = 0;
            this.Balance = 0;
            this.Descripcion = "";
            

        }

        public CuentasRegistro(int cuentaid, string descripcion, double balance)
        {
            this.CuentaId = cuentaid;
            this.Balance = balance;
            this.Descripcion = descripcion;
            
        }


        public bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into Cuentas(Balance, Descripcion) Values({0},'{1}')", this.Balance, this.Descripcion));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }


        public bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Update Cuentas Set Balance={0}, Descripcion='{1}' where CuentaId={2}", this.Balance, this.Descripcion ,this.CuentaId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Delete from Cuentas where CuentaId={0}", this.CuentaId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public bool Buscar(int IdBuscado)
        {
            DataTable dt;

            dt = conexion.getDatos(String.Format("select *from Cuentas where CuentaId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Balance = (double)dt.Rows[0]["Balance"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return dt.Rows.Count > 0;
        }
    }
}
