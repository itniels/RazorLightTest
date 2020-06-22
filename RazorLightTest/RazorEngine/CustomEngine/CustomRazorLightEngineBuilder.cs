//using System.Reflection;
//using RazorLight;
//using RazorLight.Compilation;
//using RazorLight.Generation;

//namespace RazorEngine.CustomEngine
//{
//	public class CustomRazorLightEngineBuilder : RazorLightEngineBuilder
//	{
//		public override RazorLightEngine Build()
//		{
//			var options = new RazorLightOptions();

//			if (namespaces != null)
//				options.Namespaces = namespaces;

//			if (dynamicTemplates != null)
//				options.DynamicTemplates = dynamicTemplates;

//			if (metadataReferences != null)
//				options.AdditionalMetadataReferences = metadataReferences;

//			if (excludedAssemblies != null)
//				options.ExcludedAssemblies = excludedAssemblies;

//			if (prerenderCallbacks != null)
//				options.PreRenderCallbacks = prerenderCallbacks;

//			if (cachingProvider != null)
//				options.CachingProvider = cachingProvider;

//			var metadataReferenceManager = new DefaultMetadataReferenceManager(options.AdditionalMetadataReferences, options.ExcludedAssemblies);
//			var assembly = operatingAssembly ?? Assembly.GetEntryAssembly();
//			var compiler = new RoslynCompilationService(metadataReferenceManager, assembly);

//			var sourceGenerator = new RazorSourceGenerator(CustomRazorEngine.Instance, project, options.Namespaces);
//			var templateCompiler = new RazorTemplateCompiler(sourceGenerator, compiler, project, options);
//			var templateFactoryProvider = new TemplateFactoryProvider();

//			var engineHandler = new EngineHandler(options, templateCompiler, templateFactoryProvider, cachingProvider);

//			return new RazorLightEngine(engineHandler);
//		}
//	}
//}
