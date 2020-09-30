using System.Collections.Generic;
using A_Sample_API_In_DotNetCore.DataTransferObject;

namespace A_Sample_API_In_DotNetCore.Data_Handler
{
    public interface ISampleRepo
    {
        IEnumerable<CatalogueItem> GetAllCatalogueItems();
    }
}