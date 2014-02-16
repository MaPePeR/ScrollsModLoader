using System;

namespace ScrollsModLoader.Interfaces
{

	[AttributeUsage(AttributeTargets.Assembly)]
	public class ModName : Attribute
	{
		string name;
		public ModName () : this ("UnnamedMod") {
		}
		public ModName(string s) {
			name = s;
		}
	}
	[AttributeUsage(AttributeTargets.Assembly)]
	public class ModAuthor : Attribute
	{
		string author;
		public ModAuthor () : this ("Unnamed Author") {
		}
		public ModAuthor(string s) {
			author = s;
		}
	}
	[AttributeUsage(AttributeTargets.Assembly)]
	public class ModVersion : Attribute
	{
		int version;
		public ModVersion () : this (0) {
		}
		public ModVersion(int version) {
			this.version = version;
		}
	}
}
