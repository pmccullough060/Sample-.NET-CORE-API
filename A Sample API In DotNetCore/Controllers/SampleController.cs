using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using A_Sample_API_In_DotNetCore.Data_Handler;
using A_Sample_API_In_DotNetCore.DataTransferObject;

namespace A_Sample_API_In_DotNetCore.Controllers
{
    [Route("api/Catalogue")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleRepo _sampleRepo;

        //Constructor dependency Injection
        public SampleController(ISampleRepo sampleRepo)
        {
            _sampleRepo = sampleRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CatalogueItem>> GetCatalogue()
        {
            var catalogueItems = _sampleRepo.GetAllCatalogueItems();

            return Ok(catalogueItems);
        }
    }
}