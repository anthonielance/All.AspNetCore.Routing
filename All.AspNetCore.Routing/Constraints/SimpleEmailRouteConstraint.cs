using Microsoft.AspNetCore.Routing.Constraints;

namespace All.AspNetCore.Routing.Constraints
{
    /// <summary>
    /// Constrains a route parameter that must contain at least one "@" symbol.
    /// </summary>
    public class SimpleEmailRouteConstraint : RegexRouteConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleEmailRouteConstraint"/> class.
        /// </summary>
        public SimpleEmailRouteConstraint() : base("@")
        {            
        }
    }
}
