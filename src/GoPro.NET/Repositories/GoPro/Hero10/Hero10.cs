using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoPro.NET.Models;
using GoPro.NET.Repositories.GoPro.Hero;

namespace GoPro.NET.Repositories.GoPro.Hero10
{
    internal class Hero10 : BaseHero
    {


        public Hero10(HttpClient httpClient) : base(httpClient)
        {

        }
    }
}
