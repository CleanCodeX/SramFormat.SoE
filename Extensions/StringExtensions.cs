﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace RosettaStone.Sram.SoE.Extensions
{
	internal static class StringExtensions
	{
		public static string ReplaceLineBreaks([NotNull] this string source) => source
			.Replace(Environment.NewLine + Environment.NewLine, " | ")
			.Replace(Environment.NewLine, ", ");
	}
}
