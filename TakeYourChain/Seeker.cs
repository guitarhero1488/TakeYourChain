﻿using System;
using System.Collections.Generic;
using System.Data;

namespace TakeYourChain
{
    class Seeker
    {
        private LinkedList<Chain> list;
        private Request request;

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
                foreach (DataRow _row in Connector.receivedData.Tables[0].Rows)
                {
                    Row row = new Row(_row.ItemArray[1].ToString(), _row.ItemArray[2].ToString(), _row.ItemArray[3].ToString(), _row.ItemArray[4].ToString());
                    if (string.Equals(request.SourceArt, row.OriginalArt) && string.Equals(request.SourceName, row.OriginalName))
                    {
                        if (string.Equals(request.TargetArt, row.AnalogueArt) && string.Equals(request.TargetName, row.AnalogueName))
                        {
                            throw new Exception("Target detail is the analogue");
                        }
                        else
                        {
                            Chain chain = new Chain(request.SourceArt, request.SourceName);
                            chain.InitLinkAnalogue(row.AnalogueArt, row.AnalogueName);
                            chain = SearchLink(chain, request, depth);
                        }
                    }
                }
            }
        }

        public Chain SearchLink(Chain chain, Request request, int depth)
        {
            if (depth != 0)
            {
                foreach (DataRow _row in Connector.receivedData.Tables[0].Rows)
                {
                    Row row = new Row(_row.ItemArray[1].ToString(), _row.ItemArray[2].ToString(), _row.ItemArray[3].ToString(), _row.ItemArray[4].ToString());
                    if (string.Equals(chain.Links.Last.Value.analogueArt, row.OriginalArt) && // if an article and a name of the last chain's link
                        string.Equals(chain.Links.Last.Value.analogueName, row.OriginalName))  // matches the current row's values
                    {
                        if (chain.Links.Last.Value.analogueArt == null && chain.Links.Last.Value.analogueName == null)  // if link's values of analogue aren't empty
                        {
                            chain.Links.RemoveLast();
                        }
                        if (string.Equals(chain.Links.Last.Value.analogueArt, request.TargetArt) && // if the end of current chain is target
                            string.Equals(chain.Links.Last.Value.analogueName, request.TargetName))
                        {
                            chain.Links.AddLast(new Link(row.OriginalArt, row.OriginalName));
                            chain.Links.Last.Value.InitAnalogue(row.AnalogueArt, row.AnalogueName);
                            return chain;
                        }
                        else if (row.AnalogueArt == null && row.AnalogueName == null)  // if current link hasn't analogue
                        {
                            chain.Links.AddLast(new Link(row.OriginalArt, row.OriginalName));
                            return chain;
                        }
                        else
                        {
                            chain.Links.AddLast(new Link(row.OriginalArt, row.OriginalName));
                            chain.Links.Last.Value.InitAnalogue(row.AnalogueArt, row.AnalogueName);
                            if (string.Equals(chain.Links.Last.Value.analogueArt, request.TargetArt) && 
                                string.Equals(chain.Links.Last.Value.analogueName, request.TargetName))
                            {
                                Chain rightChain = new Chain(chain.Links.First.Value.originalArt, chain.Links.First.Value.originalName);
                                rightChain.Links.Last.Value.InitAnalogue(chain.Links.First.Value.analogueArt, chain.Links.First.Value.analogueName);
                                foreach (Link link in chain.Links)
                                {
                                    if (string.Equals(link.originalArt, rightChain.Links.First.Value.originalArt) && 
                                        string.Equals(link.originalName, rightChain.Links.First.Value.originalName))
                                    {
                                        continue;
                                    }
                                    rightChain.Links.AddLast(new Link(link.originalArt, link.originalName));
                                    rightChain.Links.Last.Value.InitAnalogue(link.analogueArt, link.analogueName);
                                }
                                list.AddLast(rightChain);
                                chain.Links.RemoveLast();
                                break;
                            }
                            else
                            {
                                chain = SearchLink(chain, request, --depth);
                            }
                        }
                    }
                }
            }
            if (!string.Equals(chain.Links.Last.Value.analogueArt, request.TargetArt) ||    // if chain isn't found
                !string.Equals(chain.Links.Last.Value.analogueName, request.TargetName))
            {
                chain.Links.RemoveLast();
            }
            return chain;
        }
    }
}
