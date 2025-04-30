using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using semana5.Models;
using SQLite;

namespace semana5.Repository
{
    public class PersonaRepository
    {
        string dbPath;
        //variable de conexion sqlite conexion
        private SQLiteConnection conn;
        public string statusMesage { get; set; }

        public PersonaRepository(String path)
        {
            dbPath = path;
        }
        private void Init()
        {
            if (conn is not null)
            {
                return;
                conn = new(dbPath);
                conn.CreateTable<Persona>();
            }

        }
            public void AddNewPersona(string name)
            {
            int result = 0;
            try
            {
                Init();
                if (String.IsNullOrEmpty(name))
                    throw new Exception("El nombre es requerido");

                Persona persona = new(){Name=name};
                result = conn.Insert(persona);
                statusMesage = string.Format("dato ingresado");
            }
            catch (Exception ex)
            {
                statusMesage = string.Format("error"+ ex);
               
            }

            }
        public List<Persona> GetAllPersona()
        {
            try
            {
                Init();
                return conn.Table<Persona>().ToList();
            }catch (Exception ex)
            {
                statusMesage= string.Format("error"+ ex);
            }
            return  new List<Persona>();
        }
        /*public Delete<Persona> deletPersona(int id)
        {
            try
            {
                Init();
                return conn.Table<Persona>().Delete();
            }
        }
        */
        
    }

    
}
