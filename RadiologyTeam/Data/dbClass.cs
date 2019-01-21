using RadiologyTeam.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RadiologyTeam.Data
{
    public class dbClass
    {
        SqlConnection sqlConnection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataSet ds;
        DataTable dt;

        public DataTable getCFind(Cfind _cfind)
        {
            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                command = new SqlCommand("SELECT [ISA] FROM [Administration] WHERE [ID] = '" + (object)_cfind.ReportingPhysician + "'",sqlConnection);
                if((bool)command.ExecuteScalar())
                {
                    command = new SqlCommand("SELECT [SUID],[SDT],[PID],[PNA],[GEN],[MOD],[SDS],[CHY],[RFP],[NOI],[RPS] FROM [CFIND] WHERE SDT BETWEEN '" + _cfind.FromDate.ToString("yyyyMMdd hh:mm:ss tt") + "' AND '" + _cfind.ToDate.ToString("yyyyMMdd hh:mm:ss tt") + "' ORDER BY SDT DESC", sqlConnection);
                }
                else
                {
                    command = new SqlCommand("SELECT [SUID],[SDT],[PID],[PNA],[GEN],[MOD],[SDS],[CHY],[RFP],[NOI],[RPS] FROM [CFIND] WHERE RPID = '" + (object)_cfind.ReportingPhysician + "' AND SDT BETWEEN '" + _cfind.FromDate.ToString("yyyyMMdd hh:mm:ss tt") + "' AND '" + _cfind.ToDate.ToString("yyyyMMdd hh:mm:ss tt") + "' ORDER BY SDT DESC", sqlConnection);
                }

                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
                return dt;

            }

        }
    }
}