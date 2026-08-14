using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PrefabEvolution;

[Serializable]
[Token(Token = "0x2003BAD")]
public class PELinkage
{
	[Serializable]
	[Token(Token = "0x2003BAE")]
	public class Link
	{
		[Token(Token = "0x401967E")]
		[FieldOffset(Offset = "0x8")]
		public int LIIF;

		[Token(Token = "0x401967F")]
		[FieldOffset(Offset = "0xC")]
		public Object InstanceTarget;

		[Token(Token = "0x6017D06")]
		[Address(RVA = "0x1E2E9A8", Offset = "0x1E2E9A8", VA = "0x1E2E9A8")]
		public Link()
		{
		}

		[Token(Token = "0x6017D07")]
		[Address(RVA = "0x1E2E9B0", Offset = "0x1E2E9B0", VA = "0x1E2E9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x401967D")]
	[FieldOffset(Offset = "0x8")]
	public List<Link> Links;

	[Token(Token = "0x170018BB")]
	public Link Item
	{
		[Token(Token = "0x6017D02")]
		[Address(RVA = "0x1E2E7E4", Offset = "0x1E2E7E4", VA = "0x1E2E7E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018BC")]
	public Link Item
	{
		[Token(Token = "0x6017D03")]
		[Address(RVA = "0x1E2D660", Offset = "0x1E2D660", VA = "0x1E2D660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018BD")]
	public Link Item
	{
		[Token(Token = "0x6017D04")]
		[Address(RVA = "0x1E2D538", Offset = "0x1E2D538", VA = "0x1E2D538")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017D01")]
	[Address(RVA = "0x1E2E774", Offset = "0x1E2E774", VA = "0x1E2E774")]
	public PELinkage()
	{
	}

	[Token(Token = "0x6017D05")]
	[Address(RVA = "0x1E2E8CC", Offset = "0x1E2E8CC", VA = "0x1E2E8CC")]
	public Object GetPrefabObject(GameObject prefab, Object instanceObject)
	{
		return null;
	}
}
