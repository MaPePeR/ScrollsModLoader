using System;

namespace ScrollsModLoader.Interfaces
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public class ModName : Attribute
	{
		public readonly string name;
		public ModName () : this ("UnnamedMod") {
		}
		public ModName(string s) {
			name = s;
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public class ModAuthor : Attribute
	{
		public readonly string author;
		public ModAuthor () : this ("Unnamed Author") {
		}
		public ModAuthor(string s) {
			author = s;
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public class ModVersion : Attribute
	{
		public readonly int version;
		public ModVersion () : this (0) {
		}
		public ModVersion(int version) {
			this.version = version;
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public class ModApiVersion : Attribute
	{
		public readonly int version;
		public ModApiVersion () : this (0) {
		}
		public ModApiVersion(int version) {
			this.version = version;
		}
	}
}
