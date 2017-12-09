using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Threading;
namespace Laboratorio03.Model
{
    public class CdModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Country { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }

        public CdModel()
        {
        }

    }
}
