using Microsoft.AspNetCore.Routing.Constraints;

namespace All.AspNetCore.Routing.Constraints
{
    public class SimpleEmailRouteConstraint : RegexRouteConstraint
    {
        public SimpleEmailRouteConstraint() : base("@")
        {            
        }
    }
}
