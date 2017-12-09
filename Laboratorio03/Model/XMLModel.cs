using System;
using Laboratorio03.Model;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;
using System.Linq;

namespace Laboratorio03.Model
{
    public class XMLModel
    {
        public XMLModel()
        {
        }
        public static async Task<ObservableCollection<CdModel>> LoadXMLData()
        {
            try
            {
                ObservableCollection<CdModel> lstXml = new ObservableCollection<CdModel>();
                await Task.Factory.StartNew(delegate
                {
                    XDocument doc = XDocument.Load("catalog.xml");
                    var result = doc.Descendants("CD");
                    foreach (var item in result)
                    {
                        var a = item.Descendants("TITLE").FirstOrDefault();
                        lstXml.Add(new CdModel { Title = a.Value });
                    }
                });
                return lstXml;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
