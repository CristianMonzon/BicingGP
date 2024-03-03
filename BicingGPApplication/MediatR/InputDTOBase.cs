using BicingGPApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicingGPApplication.MediatR
{
    abstract class InputDTOBase
    {
        public string Url
        {
            get
            {
                return Provider.UrlGetStation;
            }
        }
        public string Token
        {
            get
            {
                return Provider.Token;
            }
        }

        public Provider Provider { get; set; }
    }
}
