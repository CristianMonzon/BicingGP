namespace WebApiBicingGP.Domain
{
    public class StatusInfoResult<StationInfo> : Result<StationInfo>
    {
        public StatusInfoResult(StationInfo data) : base(data)
        {
        }


    }
}