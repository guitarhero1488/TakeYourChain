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
            string[] sourceData = source.Split('/');
            string[] targetData = target.Split('/');
            SourceArt = Prepare(SourceArt);
            SourceName = Prepare(SourceName);
            TargetArt = Prepare(TargetArt);
            TargetName = Prepare(TargetName);
        }
        public string Prepare(string request)
        {
            return request.Replace(" ", "").Replace("/", "").Replace(".", "").Replace(",", "").ToLower();
        }
    }
}
