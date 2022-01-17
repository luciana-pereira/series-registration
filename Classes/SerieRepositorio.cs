using System.Collections.Generic;
using series.registration.Interfaces;

namespace series.registration
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> seriesList = new List<Serie>();
        public void Delet(int id)
        {
            seriesList[id].Delete();
        }

        public void Insert(Serie objeto)
        {
            seriesList.Add(objeto);
        }

        public List<Serie> List()
        {
            return seriesList;
        }

        public int NextId()
        {
            return seriesList.Count;
        }

        public Serie ReturnById(int id)
        {
            return seriesList[id];
        }

        public void Update(int id, Serie objeto)
        {
            seriesList[id] = objeto;
        }
    }

}