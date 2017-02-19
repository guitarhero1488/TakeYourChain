namespace TakeYourChain
{
    class Row : IPrepared
    {
        public string OriginalArt { get; }
        public string OriginalName { get; }
        public string AnalogueArt { get; }
        public string AnalogueName { get; }
        public int Trust { get; }

        public Row(string originalArt, string originalName, string analogueArt, string analogueName, string trust)
        {
            OriginalArt = Prepare(originalArt);
            OriginalName = Prepare(originalName);
            AnalogueArt = Prepare(analogueArt);
            AnalogueName = Prepare(analogueName);
            Trust = System.Convert.ToInt32(trust);
        }

        public string Prepare(string Data)
        {
            if (string.Equals(Data, "-"))
            {
                Data = null;
                return Data;
            }
            return Data.Replace(" ", "").Replace("/", "").Replace(".", "").Replace(",", "").ToLower();
        }
    }
}
