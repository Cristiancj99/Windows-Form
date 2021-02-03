using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Collections;

namespace PuntoInformacion

{
    class Database
    {
        public SQLiteConnection myConnection;
        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite3");
            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                System.Console.WriteLine("Database file created");
            }
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Clone();
            }
        }


        public void insertar(String description, double lat, double lng)
        {
            string query = "INSERT INTO puntoInteres (`descripcion`, `latitud`,`longitud` ) VALUES (@descripcion, @latitud,@longitud)";
            SQLiteCommand myCommand = new SQLiteCommand(query, this.myConnection);
            this.OpenConnection();
            myCommand.Parameters.AddWithValue("@descripcion", description);
            myCommand.Parameters.AddWithValue("@latitud", lat);
            myCommand.Parameters.AddWithValue("@longitud", lng);
            var result = myCommand.ExecuteNonQuery();
            this.CloseConnection();
        }

        public ArrayList resultadosBd()
        {
            ArrayList puntosAuxiliares = new ArrayList();
            string query = "SELECT * FROM puntoInteres";
            SQLiteCommand myCommand = new SQLiteCommand(query, this.myConnection);
            this.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    PuntoInteres auxiliar = new PuntoInteres(Convert.ToString(result["descripcion"]), Convert.ToDouble(result["latitud"]),Convert.ToDouble(result["longitud"]),Convert.ToInt32( result["id"]));
                    puntosAuxiliares.Add(auxiliar);
                }
            }
            this.CloseConnection();


            return puntosAuxiliares;
        }
    }
}