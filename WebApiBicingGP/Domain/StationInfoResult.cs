using BicingGPApplication.Domain.StationJson;
using BicingGPApplication.Domain.StatusJson;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;


namespace WebApiBicingGP.Domain
{
    public class StationInfoResult<StationInfo> : Result<StationInfo>
    {        
        public StationInfoResult(StationInfo data) : base(data)
        {
        }        
    }

}