using System;
using System.Collections.Generic;
using Mono.Cecil;
namespace ScrollsModLoader
{
	public class MethodDefinitionComparer : IComparer<MethodDefinition>
	{
		public int Compare(MethodDefinition x, MethodDefinition y) {
			if (x.EqualsReference (y))
				return 0;
			return x.Name.CompareTo (y.Name);
		}

	}
}

