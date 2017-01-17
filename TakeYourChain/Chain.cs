using System.Collections.Generic;

namespace TakeYourChain
{
    class Chain
    {
        LinkedList<Link> chain = new LinkedList<Link>();

        public Chain(string origArt, string origName)
        {
            // Created the first chain's link of view { Article, Name, null, null }
            chain.AddFirst(new Link(new string[] { origArt, origName }));
        }

        public void InitLinkAnalog(string anArt, string anName)
        {
            chain.Last.Value.InitAnalog(anArt, anName);
        }

        public void AddLink(string origArt, string origName)
        {
            chain.AddLast(new Link(new string[] { origArt, origName }));
        }

        public void RemoveLastLink()
        {
            chain.RemoveLast();
        }
    }

    class Link
    {
        public string[] original;
        public string[] analog;

        public Link(string[] orig)
        {
            original = new string[] { orig.GetValue(0).ToString(), orig.GetValue(1).ToString() };
            analog = new string[] { null, null };
        }

        public void InitAnalog(string anArt, string anName)
        {
            // Here initialized link's analog fields
            analog[0] = anArt;
            analog[1] = anName;
        }
    }
}