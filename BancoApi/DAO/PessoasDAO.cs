
using BancoApi.Banco;
using System.Collections.Generic;
using System.Linq;

namespace Api.DAO
{
    public class PessoasDAO
    {
        public static void Add(Pessoas p)
        {
            int id = GerarId();
            p.ID_Pessoa = id;
            using (var context = new Entity())
            {
                context.Pessoas.Add(p);
                context.SaveChanges();
            }
        }

        public static void Update(Pessoas pessoa, int id)
        {
            using (var context = new Entity())
            {

                pessoa.ID_Pessoa = id;
                context.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }

        public static void Remove(int id)
        {

            using (var context = new Entity())
            {
                var Pessoa = context.Pessoas.Where(p => p.ID_Pessoa == id).FirstOrDefault();
                context.Pessoas.Remove(Pessoa);
                context.SaveChanges();
            }
        }

        public static Pessoas ReturnPessoa(int id)
        {
            using (var context = new Entity())
            {
                var Pessoa = context.Pessoas.Where(p => p.ID_Pessoa == id).FirstOrDefault();
                return Pessoa;
            }
        }

        public static List<Pessoas> ReturnAll()
        {

            using (var context = new Entity())
            {
                return context.Pessoas.ToList();
            }
        }

        public static int  GerarId()
        {

            using (var context = new Entity())
            {
                List<Pessoas>p=context.Pessoas.ToList();
                int id = 0;
                
               for(int i=p.Count-1;i<p.Count; i++)
                {
                    id = p[i].ID_Pessoa;
                    id++;
                }


                return id;
            }
        }
    }
}