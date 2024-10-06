using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DessertsRepository
    {
        public List<Desserts> ObtenerTodos()
        {
            using (var conexion = Database.GetSqlConnection())
            {
                String SelectAll = "";
                SelectAll = SelectAll + "SELECT [IdPostre] " + "\n";
                SelectAll = SelectAll + "      ,[Nombre] " + "\n";
                SelectAll = SelectAll + "      ,[Descripcion] " + "\n";
                SelectAll = SelectAll + "      ,[Precio] " + "\n";
                SelectAll = SelectAll + "      ,[FechaVencimiento] " + "\n";
                SelectAll = SelectAll + "      ,[Estado] " + "\n";
                SelectAll = SelectAll + "      ,[Stock] " + "\n";
                SelectAll = SelectAll + "      ,[Calorias] " + "\n";
                SelectAll = SelectAll + "  FROM [dbo].[Postres]";


                var cliente = conexion.Query<Desserts>(SelectAll).ToList();
                return cliente;
            }
        }
        public Desserts ObtenerPorID(string id)
        {

            using (var conexion = Database.GetSqlConnection())
            {

                String SelectPorID = "";
                SelectPorID = SelectPorID + "SELECT [IdPostre] " + "\n";
                SelectPorID = SelectPorID + "      ,[Nombre] " + "\n";
                SelectPorID = SelectPorID + "      ,[Descripcion] " + "\n";
                SelectPorID = SelectPorID + "      ,[Precio] " + "\n";
                SelectPorID = SelectPorID + "      ,[FechaVencimiento] " + "\n";
                SelectPorID = SelectPorID + "      ,[Estado] " + "\n";
                SelectPorID = SelectPorID + "      ,[Stock] " + "\n";
                SelectPorID = SelectPorID + "      ,[Calorias] " + "\n";
                SelectPorID = SelectPorID + "  FROM [dbo].[Postres]";
                SelectPorID = SelectPorID + "  WHERE IdPostre = @IdPostre";

                var postre = conexion.QueryFirstOrDefault<Desserts>(SelectPorID, new { IdPostre = id });
                return postre;
            }

        }
        public int EliminarPostre(string Id)
        {

            using (var conexion = Database.GetSqlConnection())
            {

                String Delete = "";
                Delete = Delete + "DELETE FROM [dbo].[Postres] " + "\n";
                Delete = Delete + "      WHERE IdPostre = @IdPostre";

                var eliminadas = conexion.Execute(Delete, new
                {
                    IdPostre = Id
                });
                return eliminadas;
            }
        }
    }
}
