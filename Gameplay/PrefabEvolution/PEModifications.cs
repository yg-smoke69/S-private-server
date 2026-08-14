using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PrefabEvolution;

[Serializable]
[Token(Token = "0x2003BAF")]
public class PEModifications
{
	[Serializable]
	[Token(Token = "0x2003BB0")]
	public class PropertyData
	{
		[Token(Token = "0x2003BB1")]
		public enum PropertyMode
		{
			[Token(Token = "0x401968B")]
			Default,
			[Token(Token = "0x401968C")]
			Keep,
			[Token(Token = "0x401968D")]
			Ignore
		}

		[Token(Token = "0x4019685")]
		[FieldOffset(Offset = "0x8")]
		public Object Object;

		[Token(Token = "0x4019686")]
		[FieldOffset(Offset = "0xC")]
		public int ObjeckLink;

		[Token(Token = "0x4019687")]
		[FieldOffset(Offset = "0x10")]
		public string PropertyPath;

		[Token(Token = "0x4019688")]
		[FieldOffset(Offset = "0x14")]
		public PropertyMode Mode;

		[Token(Token = "0x4019689")]
		[FieldOffset(Offset = "0x18")]
		public object UserData;

		[Token(Token = "0x6017D09")]
		[Address(RVA = "0x1E2EB4C", Offset = "0x1E2EB4C", VA = "0x1E2EB4C")]
		public PropertyData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003BB2")]
	public class HierarchyData
	{
		[Token(Token = "0x401968E")]
		[FieldOffset(Offset = "0x8")]
		public Transform child;

		[Token(Token = "0x401968F")]
		[FieldOffset(Offset = "0xC")]
		public Transform parent;

		[Token(Token = "0x6017D0A")]
		[Address(RVA = "0x1E2EB44", Offset = "0x1E2EB44", VA = "0x1E2EB44")]
		public HierarchyData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003BB3")]
	public class ComponentsData
	{
		[Token(Token = "0x4019690")]
		[FieldOffset(Offset = "0x8")]
		public Component child;

		[Token(Token = "0x4019691")]
		[FieldOffset(Offset = "0xC")]
		public GameObject parent;

		[Token(Token = "0x6017D0B")]
		[Address(RVA = "0x1E2EB3C", Offset = "0x1E2EB3C", VA = "0x1E2EB3C")]
		public ComponentsData()
		{
		}
	}

	[Token(Token = "0x4019680")]
	[FieldOffset(Offset = "0x8")]
	public List<PropertyData> Modificated;

	[Token(Token = "0x4019681")]
	[FieldOffset(Offset = "0xC")]
	public List<HierarchyData> NonPrefabObjects;

	[Token(Token = "0x4019682")]
	[FieldOffset(Offset = "0x10")]
	public List<ComponentsData> NonPrefabComponents;

	[Token(Token = "0x4019683")]
	[FieldOffset(Offset = "0x14")]
	public List<int> RemovedObjects;

	[Token(Token = "0x4019684")]
	[FieldOffset(Offset = "0x18")]
	public List<HierarchyData> TransformParentChanges;

	[Token(Token = "0x6017D08")]
	[Address(RVA = "0x1E2EA78", Offset = "0x1E2EA78", VA = "0x1E2EA78")]
	public PEModifications()
	{
	}
}
