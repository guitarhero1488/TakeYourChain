namespace TakeYourChain
{
    class Request : IPrepared
    {
        public string SourceArt { get; set; }
        public string SourceName { get; set; }
        public string TargetArt { get; }
        public string TargetName { get; }
        public Request(string source, string target)
        {
            string[] sourceData = source.Split(new char[] { '\t', '/' });
            if (sourceData.Length < 2)
            {
                throw new System.Exception("Request for source detail must contains both article and name!");
            }
            string[] targetData = target.Split(new char[] { '\t', '/' });
            if (targetData.Length < 2)
            {
                throw new System.Exception("Request for target detail must contains both article and name!");
            }
            SourceArt = Prepare(sourceData.GetValue(0).ToString());
            SourceName = Prepare(sourceData.GetValue(1).ToString());
            TargetArt = Prepare(targetData.GetValue(0).ToString());
            TargetName = Prepare(targetData.GetValue(1).ToString());
        }
        public string Prepare(string request)
        {
            return request.Replace(" ", "").Replace("/", "").Replace(".", "").Replace(",", "").ToLower();
        }
    }
}
