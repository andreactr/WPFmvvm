using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tesis.Model
{
    public class MainModel
    {
        DataAccess data = new DataAccess();

        public List<Person> GetPersonas()
        {
            return data.GetPersonas();
        }

        public void CreatePersona(string name, int age, string email)
        {
            if (name == null || name == "")
                throw new Exception("El nombre no puede ir vacío");
            if (email == null || email == "")
                throw new Exception("El email no puede ir vacío");
            if (age <= 0)
                throw new Exception("La edad debe ser mayor a 0");

            data.CreatePersona(name, age, email);
        }

        public void UpdatePersonas(int id, string name, int age, string email)
        {
            if (name == null || name == "")
                throw new Exception("El nombre no puede ir vacío");
            if (email == null || email == "")
                throw new Exception("El email no puede ir vacío");
            if (age <= 0)
                throw new Exception("La edad debe ser mayor a 0");

            data.UpdatePersonas(id, name, age, email);   
        }

        public void DeletePersona(Person persona)
        {
            if(persona == null)
            throw new Exception("no hay ninguna fila seleccionada");
            data.DeletePersonas(persona.Id);
        }

    }
}
