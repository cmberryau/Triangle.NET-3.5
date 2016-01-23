// -----------------------------------------------------------------------
// <copyright file="AdjacencyMatrix.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// .NET 3.5 / Unity3D compatibility by Chris Berry, http://www.chrisberry.com.au
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Tools
{
    public static class Utilities
    {
        /// <summary>
        /// Replacement for String.IsNullOrWhiteSpace for .NET 3.5
        /// </summary>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            if (value == null)
                return true;

            return string.IsNullOrEmpty(value.Trim());
        }

        /// <summary>
        /// Replacement for Covariance for .NET 3.5
        /// </summary>
        public static IEnumerable<Point> ToPoints(this IEnumerable<Vertex> vertices)
        {
            foreach (var vertex in vertices)
            {
                yield return vertex;
            }
        }

        /// <summary>
        /// Replacement for Covariance for .NET 3.5
        /// </summary>
        public static IEnumerable<ISegment> ToEdges(this Dictionary<int, SubSegment> dict)
        {
            foreach (var value in dict.Values)
            {
                yield return value;
            }
        }
    }
}
