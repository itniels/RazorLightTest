using System.Reflection;
using RazorEngine.ViewModels;
using RazorLight;

namespace RazorEngine
{
	public static class RazorRendere
	{
		public static string Render(string key)
		{
			var engine = new RazorLightEngineBuilder()
				.SetOperatingAssembly(Assembly.GetAssembly(typeof(RazorRendere)))
				.UseEmbeddedResourcesProject(typeof(RazorRendere))
				.UseMemoryCachingProvider()
				.Build();

			var model = new SuccessViewModel { Name = "John Doe", Age = 37 };

			return engine.CompileRenderAsync($"Templates.{key}", model).Result;
		}
	}
}