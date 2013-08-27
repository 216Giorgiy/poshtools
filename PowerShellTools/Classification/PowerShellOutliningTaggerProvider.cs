using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace PowerShellTools.Classification
{
	[TagType(typeof(IOutliningRegionTag)), ContentType("PowerShell"), Export(typeof(ITaggerProvider))]
	internal class PowerShellOutliningTaggerProvider : ITaggerProvider
	{
		public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
		{
			Func<ITagger<T>> creator = () => new PowerShellOutliningTagger(buffer) as ITagger<T>;
			return buffer.Properties.GetOrCreateSingletonProperty<ITagger<T>>(typeof(PowerShellOutliningTagger), creator);
		}
	}
}
