using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyModel;
using Xunit;

namespace TestDependencyContext
{
	public class ReferencePathResolverTests
	{
		[Fact]
		public void can_get_reference_paths() {
			var referencePaths = ReferencePathResolver.GetAllReferences(DependencyContext.Load(typeof(ReferencePathResolverTests).GetTypeInfo().Assembly)).ToList();
			Assert.NotEmpty(referencePaths);
		}
	}
}
