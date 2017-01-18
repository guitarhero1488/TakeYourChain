using System.Collections.Generic;

namespace TakeYourChain
{
    class Chain
    {
        public LinkedList<Link> Links = new LinkedList<Link>();

        public Chain(string origArt, string origName)
        {
            // Created the first chain's link of view { Article, Name, null, null }
            Links.AddFirst(new Link(new string[] { origArt, origName }));
        }

        public void InitLinkAnalog(string anArt, string anName)
        {
            Links.Last.Value.InitAnalog(anArt, anName);
        }

        public string[] GetLinkOriginal()
        {
            return new string[] { Links.Last.Value.originalArt, Links.Last.Value.originalName };
        }

        public string[] GetLinkAnalog()
        {
            return new string[] { Links.Last.Value.analogArt, Links.Last.Value.analogName };
        }

        public void AddLink(string origArt, string origName)
        {
            Links.AddLast(new Link(new string[] { origArt, origName }));
        }

        public void RemoveLastLink()
        {
            Links.RemoveLast();
        }
    }

    class Link
    {
        public string originalArt { get; set; }
        public string originalName { get; set; }
        public string analogArt { get; set; }
        public string analogName { get; set; }

        public Link(string[] orig)
        {
            originalArt = orig.GetValue(0).ToString();
            originalName = orig.GetValue(1).ToString();
            analogArt = null;
            analogName = null;
        }

        public void InitAnalog(string anArt, string anName)
        {
            // Here initialized link's analog fields
            analogArt = anArt;
            analogName = anName;
        }
    }
}