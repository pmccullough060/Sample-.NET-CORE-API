using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A_Sample_API_In_DotNetCore.DataTransferObject;

namespace A_Sample_API_In_DotNetCore.Data_Handler
{
    public class SampleRepo : ISampleRepo
    {
        public IEnumerable<CatalogueItem> GetAllCatalogueItems()
        {
            var catalogueItem = new List<CatalogueItem>
            {
                new CatalogueItem{Id = 0, Name = "Manhole", Description = "DMRB Manhole"},
                new CatalogueItem{Id = 1, Name = "Catchpit", Description = "DMRB Catchpit"},
                new CatalogueItem{Id = 2, Name = "Inspection Chamber", Description = "DMRB Inspection Chamber"},
            };

            return catalogueItem;
        }
    }
}
