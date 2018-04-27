using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FedericoWebApi.Models;

namespace FedericoWebApi.Controllers {
	public class ValuesController : ApiController {

		DomainModel dm = new DomainModel();
		// GET api/values
		public IEnumerable<Prodotto> Get() {
			return dm.SearchByDescrizione("");
		}

		// GET api/values/5
		public Prodotto Get(int id) {
			return  dm.SearchByCode(id);
		}

		// POST api/values
		public void Post([FromBody]string value) {
		}

		// PUT api/values/5
		public void Put(int id,[FromBody]string value) {
		}

		// DELETE api/values/5
		public void Delete(int id) {
		}
	}
}
