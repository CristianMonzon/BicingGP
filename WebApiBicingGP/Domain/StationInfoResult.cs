namespace WebApiBicingGP.Domain
{
    public class StationInfoResult<StationInfo> : Result<StationInfo>
    {        
        public StationInfoResult(StationInfo data) : base(data)
        {
        }        
    }

}