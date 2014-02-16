using System;
using Mono.Cecil;
namespace ScrollsModLoader.Interfaces
{
	public delegate void BeforeInvokeDelegate(InvocationInfo info);
	public delegate void AfterInvokeDelegate(InvocationInfo info, ref object returnValue);
	public delegate bool WantsToReplaceDelegate(InvocationInfo roinfo);
	public delegate void ReplaceDelegate(InvocationInfo info, out object returnValue);
	public interface IHookInformation {
		void addBeforeInvokeHook(MethodDefinition m, BeforeInvokeDelegate hook);
		void addAfterInvokeHook(MethodDefinition m, AfterInvokeDelegate hook);
		void addReplaceHook(MethodDefinition m, WantsToReplaceDelegate conditionDelegate, ReplaceDelegate hook);
		TypeDefinitionCollection getTypes();
		int getExeVersion ();
	}
	public abstract class BaseMod2
	{
		public BaseMod2 (IHookInformation hookInformation)
		{
			//So extending Classes also have this Constructor
		}

		public abstract void Init ();
	}
}

