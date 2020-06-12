﻿using DMS.GLSL.Language;
using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;

namespace DMS.GLSL.Classification
{
	class TokenTypes : ITokenTypes<IClassificationType>
	{
		public TokenTypes(IClassificationTypeRegistryService classificationTypeRegistry)
		{
			Comment = classificationTypeRegistry.GetClassificationType(PredefinedClassificationTypeNames.Comment);
			Identifier = classificationTypeRegistry.GetClassificationType(PredefinedClassificationTypeNames.Identifier);
			Number = classificationTypeRegistry.GetClassificationType(PredefinedClassificationTypeNames.Number);
			Operator = classificationTypeRegistry.GetClassificationType(PredefinedClassificationTypeNames.Operator);
			PreprocessorKeyword = classificationTypeRegistry.GetClassificationType(PredefinedClassificationTypeNames.PreprocessorKeyword);

			Function = classificationTypeRegistry.GetClassificationType(GlslClassificationTypes.Function);
			Keyword = classificationTypeRegistry.GetClassificationType(GlslClassificationTypes.Keyword);
			UserKeyWord1 = classificationTypeRegistry.GetClassificationType(GlslClassificationTypes.UserKeyWord1);
			UserKeyWord2 = classificationTypeRegistry.GetClassificationType(GlslClassificationTypes.UserKeyWord2);
			Variable = classificationTypeRegistry.GetClassificationType(GlslClassificationTypes.Variable);
		}

		public IClassificationType Comment { get; }
		public IClassificationType Function { get; }
		public IClassificationType Identifier { get; }
		public IClassificationType Keyword { get; }
		public IClassificationType Number { get; }
		public IClassificationType Operator { get; }
		public IClassificationType PreprocessorKeyword { get; }
		public IClassificationType UserKeyWord1 { get; }
		public IClassificationType UserKeyWord2 { get; }
		public IClassificationType Variable { get; }

	}
}