using IntroToEF.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF
{
    public class Business
    {
        private ISamuraiRepo _repo;

        public Business()
        {
            _repo = new SamuraiRepo();
        }
    }
}
