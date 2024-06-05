using ApiTarea_infrastructure.Data;
using ApiTarea_infrastructure.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTarea_Domain.Entity;
namespace ApiTarea_infrastructure.Repository
{
    public class PersonaRepository : IPersonaRepository
    {
        public readonly IDbConnection connection;

        public PersonaRepository(ConnectionService connectionService)
        { 
            string  connsql = connectionService.getConnection();

            connection = new SqlConnection(connsql);
        }

        //llama el procedimiento almacenado para realizar un select de todas las personas en la tabla
        public async Task<dynamic> getPersona()
        {
            DynamicParameters parametro = new DynamicParameters();

            IEnumerable<dynamic> lista = await connection.QueryAsync<dynamic>("spPersonasGet", parametro, commandType: CommandType.StoredProcedure);

            return lista.ToList();
        }

        //llama el procedimiento almacenado en la base de datos para insertar valores en la tabla
        public async Task AddPersonaAsync(Persona persona)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Nombre", persona.Nombre, DbType.String);
            parameters.Add("@Apellido1", persona.Apellido1, DbType.String);
            parameters.Add("@Apellido2", persona.Apellido2, DbType.String);
            parameters.Add("@Telefono", persona.Telefono, DbType.String);

            await connection.ExecuteAsync("spPersonasPost", parameters, commandType: CommandType.StoredProcedure);
        }


    }
}
