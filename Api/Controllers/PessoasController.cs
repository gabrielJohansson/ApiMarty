
using Api.DAO;
using BancoApi.Banco;
using System.Collections.Generic;
using System.Web.Http;

namespace Api.Controllers
{
    [AllowAnonymous]
    public class PessoasController : ApiController
    {
        // GET: api/Pessoa
        public IEnumerable<Pessoas> Get()
        {
            return PessoasDAO.ReturnAll();
        }

        // GET: api/Pessoa/5
        public Pessoas Get(int id)
        {
            return PessoasDAO.ReturnPessoa(id);
        }

        // POST: api/Pessoa
        public void Post([FromBody]Pessoas value)
        {
            //value.DtaCadastro_Pessoa = DateTime.Now;
            PessoasDAO.Add(value);
        }

        // PUT: api/Pessoa/5
        public void Put(int id, [FromBody]Pessoas value)
        {
            PessoasDAO.Update(value, id);
        }

        // DELETE: api/Pessoa/5
        public void Delete(int id)
        {
            PessoasDAO.Remove(id);
        }
    }
}
