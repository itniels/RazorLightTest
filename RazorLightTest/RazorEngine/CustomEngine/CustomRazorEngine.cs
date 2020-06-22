//using System.Linq;
//using RazorEngine.CustomEngine;
//using Microsoft.AspNetCore.Mvc.Razor.Extensions;
//using Microsoft.AspNetCore.Razor.Language;
//using Microsoft.AspNetCore.Razor.Language.Extensions;
//using RazorLight.Instrumentation;

//namespace RazorLight
//{
//	public class CustomRazorEngine
//	{
//		public static RazorEngine Instance => GetEngine();

//		private static RazorEngine GetEngine()
//		{
//			var configuration = RazorConfiguration.Default;
//			var razorProjectEngine = RazorProjectEngine.Create(configuration, new DummyRazorProjectFileSystem(), builder => {
//				RazorLight.Instrumentation.InjectDirective.Register(builder);
//				RazorLight.Instrumentation.ModelDirective.Register(builder);

//				if (!RazorLanguageVersion.TryParse("3.0", out var razorLanguageVersion) || configuration.LanguageVersion.CompareTo(razorLanguageVersion) < 0)
//				{
//					Microsoft.AspNetCore.Razor.Language.Extensions.NamespaceDirective.Register(builder);
//					FunctionsDirective.Register(builder);
//					InheritsDirective.Register(builder);
//					SectionDirective.Register(builder);
//				}

//				var sectionDirective = builder.Features.OfType<SectionDirectivePass>().FirstOrDefault();
//				if (sectionDirective == null)
//				{
//					SectionDirective.Register(builder);
//				}

//				builder.Features.Add(new ModelExpressionPass());
//				builder.Features.Add(new RazorLightTemplateDocumentClassifierPass());
//				builder.Features.Add(new RazorLightAssemblyAttributeInjectionPass());

//				builder.Features.Add(new InstrumentationPass());

//				//builder.Features.Add(new ViewComponentTagHelperPass());

//				builder.AddTargetExtension(new TemplateTargetExtension() {
//					TemplateTypeName = "global::RazorLight.Razor.RazorLightHelperResult",
//				});

//				OverrideRuntimeNodeWriterTemplateTypeNamePhase.Register(builder);
//			});

//			return razorProjectEngine.Engine;
//		}
//	}
//}
