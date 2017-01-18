using System;
using System.Collections.Generic;
using System.Data;

namespace TakeYourChain
{
    class Seeker
    {
        public LinkedList<Chain> list;
        Request request;

        public Seeker(string source, string target, int depth)
        {
            request = new Request(source, target);
            list = new LinkedList<Chain>();
            SearchChain(list, request, depth);
        }

        private void SearchChain(LinkedList<Chain> list, Request request, int depth)
        {
            if (depth != 0)
            {
                foreach (DataRow row in Connector.receivedData.Tables[0].Rows)
                {
                    if (string.Equals(request.SourceArt, row.ItemArray[1].ToString()) && string.Equals(request.SourceName, row.ItemArray[2].ToString()))
                    {
                        if (string.Equals(request.TargetArt, row.ItemArray[3].ToString()) && string.Equals(request.TargetName, row.ItemArray[4].ToString()))
                        {
                            throw new Exception("Target detail is an analogue of this");
                        }
                        else
                        {
                            Chain chain = new Chain(request.SourceArt, request.SourceName);
                            chain.InitLinkAnalog(row.ItemArray[3].ToString(), row.ItemArray[4].ToString());
                            request.SourceArt = row.ItemArray[3].ToString();
                            request.SourceName = row.ItemArray[4].ToString();
                            chain.Links.AddLast(SearchLink(chain, request, depth));
                            if (chain.Links.Last.Value.analogArt == null && chain.Links.Last.Value.analogName == null)
                            {
                                chain.RemoveLastLink();
                                chain.RemoveLastLink();
                                request.SourceArt = chain.Links.Last.Value.analogArt;
                                request.SourceName = chain.Links.Last.Value.analogName;
                            }
                            list.AddLast(chain);
                        }
                    }
                }
            }
        }

        public Link SearchLink(Chain chain, Request request, int depth)
        {
            if (depth != 0)
            {
                foreach (DataRow row in Connector.receivedData.Tables[0].Rows)
                {
                    if (string.Equals(chain.Links.Last.Value.analogArt, row.ItemArray[1].ToString()) && string.Equals(chain.Links.Last.Value.analogName, row.ItemArray[2].ToString()))
                    {
                        if (string.Equals(request.TargetArt, row.ItemArray[3].ToString()) && string.Equals(request.TargetName, row.ItemArray[4].ToString()))
                        {
                            chain.AddLink(request.SourceArt, request.SourceName);
                            chain.InitLinkAnalog(row.ItemArray[3].ToString(), row.ItemArray[4].ToString());
                            return chain.Links.Last.Value;
                        }
                        request.SourceArt = row.ItemArray[3].ToString();
                        request.SourceName = row.ItemArray[4].ToString();
                        chain.Links.AddLast(new Link(new string[] { row.ItemArray[1].ToString(), row.ItemArray[2].ToString() }));
                        chain.InitLinkAnalog(row.ItemArray[3].ToString(), row.ItemArray[4].ToString());
                        chain.Links.AddLast(SearchLink(chain, request, --depth));
                    }
                }
            }
            return new Link(new string[] { request.SourceArt, request.SourceName });
        }
    }
}
