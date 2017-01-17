namespace TakeYourChain
{
    class Request
    {
        public string SourceArt { get; }
        public string SourceName { get; }
        public string TargetArt { get; }
        public string TargetName { get; }
        public Request(string _source, string _target)
        {
            string[] sourceData = PrepareData(_source);
            string[] targetData = PrepareData(_target);
            SourceArt = sourceData.GetValue(0).ToString();
            SourceName = sourceData.GetValue(1).ToString();
            TargetArt = targetData.GetValue(0).ToString();
            TargetName = targetData.GetValue(1).ToString();
        }
        public static string[] PrepareData(string request)
        {
            return request.Split('/');
        }
    }
}
