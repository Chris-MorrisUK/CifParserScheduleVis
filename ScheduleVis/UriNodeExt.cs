using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VDS.RDF;

namespace ScheduleVis
{
 /// <summary>
 /// This contains some extention methods for URI node
 /// </summary>
    public static class UriNodeExt
    {
        public static string ToDisplayString(this UriNode node)
        {
            IEnumerable<Triple> labels = node.Graph.GetTriplesWithSubjectPredicate(node,
                node.Graph.CreateUriNode(UriFactory.Create(Properties.Settings.Default.Label))
                );
            if (labels.Any())
            {
                Triple firstLabel = labels.First();
                ILiteralNode labelNode = firstLabel.Object as ILiteralNode;
                return labelNode.Value;
            }
            else
            {
                return node.Uri.Segments[node.Uri.Segments.Count() - 1];
            }
        }

        public static IUriNode RdfType(IGraph target)
        {
            Uri theUri = UriFactory.Create(Properties.Settings.Default.RDFType);
            return target.CreateUriNode(theUri);
        }


        public static void LabelNode(this IUriNode toLabel, string label, string lang)
        {
            IUriNode labNode = toLabel.Graph.CreateUriNode(UriFactory.Create(Properties.Settings.Default.Label));
            ILiteralNode textNode = toLabel.Graph.CreateLiteralNode(label, lang);
            toLabel.Graph.Assert(toLabel, labNode, textNode);
        }

        public static void AssertResponibility(this IUriNode created, IUriNode creationActivity)
        {
            IUriNode provWasGeneratedBy = created.Graph.CreateUriNode(UriFactory.Create(Properties.Settings.Default.provWasGeneratedBy));
            created.Graph.Assert(created, provWasGeneratedBy, creationActivity);
        }

        public static void IdentifyNode(this IUriNode toIdent, INode myID)
        {
            IUriNode idNode = toIdent.Graph.CreateUriNode(Properties.Settings.Default.ID);
            toIdent.Graph.Assert(toIdent, idNode, myID);
        }
    }
}
