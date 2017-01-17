using System;
using System.Collections.Generic;
using System.Data;

namespace TakeYourChain
{
    class Seeker
    {
        public static LinkedList<Chain> chains; // that contains all chains

        public static void SearchChain(string sourceData, string targetData, string iterCount)
        {
            chains = new LinkedList<Chain>();
            LinkedList<Chain> originals = new LinkedList<Chain>();  // list of chains where initialized original's fields
            int depth = Convert.ToInt32(iterCount);
            Request request = new Request(sourceData, targetData);  // processed search request

            try
            {
                InitChainList(request, originals);  // create list of chains' first elements
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }            
        }

        private static void InitChainList(Request request, LinkedList<Chain> originals)
        {
            LinkedList<Chain> list = Connector.CreateOriginalsList(new string[] { request.SourceArt, request.SourceName });
            if (list == null)
            {
                throw new Exception("No source detail is relevant");
            }
            LinkedListNode<Chain> node;
            for (node = list.First; node != null; node = node.Next)
            {
                originals.AddLast(new LinkedListNode<Chain>(node.Value));
            }
        }
    }
}
