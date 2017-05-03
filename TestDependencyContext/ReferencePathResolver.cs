using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyModel;

namespace TestDependencyContext
{
	public static class ReferencePathResolver
	{
		public static IEnumerable<string> GetAllReferences(DependencyContext context) {
			return context.CompileLibraries.SelectMany(x => x.ResolveReferencePaths());
		}
	}
}
