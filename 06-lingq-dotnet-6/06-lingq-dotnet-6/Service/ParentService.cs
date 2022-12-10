using _06_linq.Model;
using _06_linq_dotnet_5.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_linq_dotnet_5.Service
{
    class ParentService
    {
        private ParentRepo parentRepo;

        public ParentService()
        {
            parentRepo = new ParentRepo();
        }

        public void ParentWomanLinq()
        {
            //IEnumerable<Parent> parent= from 
        }

        public void ParantWomanLambda()
        {
            //List<Parent> parent=parentRepo.Parents
        }
    }
}
