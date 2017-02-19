using System.Collections.Generic;

namespace TakeYourChain
{
    class Chain
    {
        public LinkedList<Link> Links = new LinkedList<Link>();

        public Chain(string origArt, string origName)
        {
            // Created the first chain's link of view { Article, Name, null, null }
            Links.AddFirst(new Link(origArt, origName));
        }

        public void InitLinkAnalogue(string anArt, string anName)
        {
            Links.Last.Value.InitAnalogue(anArt, anName);
        }

        public string[] GetLinkOriginal()
        {
            return new string[] { Links.Last.Value.originalArt, Links.Last.Value.originalName };
        }

        public string[] GetLinkAnalogue()
        {
            return new string[] { Links.Last.Value.analogueArt, Links.Last.Value.analogueName };
        }

        public void AddLink(string origArt, string origName)
        {
            Links.AddLast(new Link(origArt, origName));
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
        public string analogueArt { get; set; }
        public string analogueName { get; set; }

        public Link(string origArt, string origName)
        {
            originalArt = origArt;
            originalName = origName;
            analogueArt = null;
            analogueName = null;
        }

        public void InitAnalogue(string anArt, string anName)
        {
            // Here initialized link's analogue fields
            analogueArt = anArt;
            analogueName = anName;
        }
    }
}