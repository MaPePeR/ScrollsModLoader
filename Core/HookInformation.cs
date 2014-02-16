using System;
using ScrollsModLoader.Interfaces;
using Mono.Cecil;
using System.Collections.Generic;
namespace ScrollsModLoader
{
	public class HookInformation : IHookInformation 
	{
		struct BeforeHook {
			public readonly MethodDefinition m;
			public readonly BeforeInvokeDelegate hook;
			public BeforeHook(MethodDefinition m, BeforeInvokeDelegate hook) {
				this.m = m; this.hook = hook;
			}
		}
		struct AfterHook {
			public readonly MethodDefinition m;
			public readonly AfterInvokeDelegate hook;
			public AfterHook(MethodDefinition m, AfterInvokeDelegate hook) {
				this.m = m; this.hook = hook;
			}
		}
		struct ReplaceHook {
			public readonly MethodDefinition m;
			public readonly WantsToReplaceDelegate conditionDelegate;
			public readonly ReplaceDelegate hook;
			public ReplaceHook(MethodDefinition m, WantsToReplaceDelegate conditionDelegate, ReplaceDelegate hook) {
				this.m = m; this.hook = hook;
				this.conditionDelegate = conditionDelegate;
			}
		}

		TypeDefinitionCollection types;
		int exeVersion;
		List<BeforeHook> beforeHooks = new List<BeforeHook> ();
		List<AfterHook> afterHooks = new List<AfterHook> ();
		List<ReplaceHook> replaceHooks = new List<ReplaceHook> ();
		//LinkedList<MethodDefinition> allHooks = new LinkedList<MethodDefinition> (); //(new MethodDefinitionComparer());
		public HookInformation (TypeDefinitionCollection types, int exeVersion)
		{
			this.types = types;
			this.exeVersion = exeVersion;
		}
		public void addBeforeInvokeHook(MethodDefinition m, BeforeInvokeDelegate hook) {
			if (m == null || hook == null)
				throw new NullReferenceException();
			beforeHooks.Add(new BeforeHook (m, hook));
			//allHooks.Add (m);
		}
		public void addAfterInvokeHook(MethodDefinition m, AfterInvokeDelegate hook) {
			if (m == null || hook == null)
				throw new NullReferenceException();
			afterHooks.Add(new AfterHook (m, hook));
			//allHooks.Add (m);
		}
		public void addReplaceHook(MethodDefinition m, WantsToReplaceDelegate conditionDelegate, ReplaceDelegate hook) {
			if (m == null || conditionDelegate  == null || hook == null)
				throw new NullReferenceException();
			replaceHooks.Add (new ReplaceHook (m ,conditionDelegate, hook));
			//allHooks.Add (m);
		}
		public TypeDefinitionCollection getTypes() {
			return types;
		}
		public int getExeVersion () {
			return exeVersion;
		}
	}
}

