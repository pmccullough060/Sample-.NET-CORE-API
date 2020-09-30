using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Sample_API_In_DotNetCore.DataTransferObject
{
    public class CatalogueItem : ICatalogueItem
    {
        //class to template each item of data against

        //In reality this would hook up to the FME workspace/Database were each catalogue item is stored

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
