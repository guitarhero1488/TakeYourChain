namespace TakeYourChain
{
    class Row : IPrepared
    {
        public string OriginalArt { get; }
        public string OriginalName { get; }
        public string AnalogueArt { get; }
        public string AnalogueName { get; }

        public Row(string originalArt, string originalName, string analogueArt, string analogueName)
        {
            OriginalArt = Prepare(originalArt);
            OriginalName = Prepare(originalName);
            AnalogueArt = Prepare(analogueArt);
            AnalogueName = Prepare(analogueName);
        }

        public string Prepare(string Data)
        {
            return Data.Replace(" ", "").Replace("/", "").Replace(".", "").Replace(",", "").ToLower();
        }
    }
}
