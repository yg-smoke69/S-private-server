using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace PrefabEvolution;

[Token(Token = "0x2003BA4")]
public class BaseExposedData : _Attribute
{
	[Token(Token = "0x2003BA5")]
	public struct Comparer : _Attribute
	{
		[Token(Token = "0x6017CE1")]
		[Address(RVA = "0x93C518", Offset = "0x93C518", VA = "0x93C518", Slot = "4")]
		public int Compare(BaseExposedData x, BaseExposedData y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2003BA6")]
	private sealed class _003C_003Ec__AnonStorey0
	{
		[Token(Token = "0x401966D")]
		[FieldOffset(Offset = "0x8")]
		internal BaseExposedData parent;

		[Token(Token = "0x6017CE2")]
		[Address(RVA = "0x1E2A074", Offset = "0x1E2A074", VA = "0x1E2A074")]
		public _003C_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6017CE3")]
		[Address(RVA = "0x1E2A450", Offset = "0x1E2A450", VA = "0x1E2A450")]
		internal bool _003C_003Em__0(BaseExposedData i)
		{
			return default(bool);
		}
	}

	[NonSerialized]
	[Token(Token = "0x4019668")]
	[FieldOffset(Offset = "0x8")]
	public PEExposedProperties Container;

	[Token(Token = "0x4019669")]
	[FieldOffset(Offset = "0xC")]
	private int guid;

	[Token(Token = "0x401966A")]
	[FieldOffset(Offset = "0x10")]
	public string Label;

	[Token(Token = "0x401966B")]
	[FieldOffset(Offset = "0x14")]
	public int ParentId;

	[Token(Token = "0x401966C")]
	[FieldOffset(Offset = "0x18")]
	public float Order;

	[Token(Token = "0x170018AD")]
	public int SiblingIndex
	{
		[Token(Token = "0x6017CD5")]
		[Address(RVA = "0x1E29A24", Offset = "0x1E29A24", VA = "0x1E29A24")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170018AE")]
	public int Id
	{
		[Token(Token = "0x6017CD8")]
		[Address(RVA = "0x1E29D8C", Offset = "0x1E29D8C", VA = "0x1E29D8C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170018AF")]
	public BaseExposedData Parent
	{
		[Token(Token = "0x6017CD9")]
		[Address(RVA = "0x1E29D94", Offset = "0x1E29D94", VA = "0x1E29D94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017CDA")]
		[Address(RVA = "0x1E29EB4", Offset = "0x1E29EB4", VA = "0x1E29EB4")]
		set
		{
		}
	}

	[Token(Token = "0x170018B0")]
	public IEnumerable<BaseExposedData> Children
	{
		[Token(Token = "0x6017CDB")]
		[Address(RVA = "0x1E29EE0", Offset = "0x1E29EE0", VA = "0x1E29EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018B1")]
	public IEnumerable<BaseExposedData> Brothers
	{
		[Token(Token = "0x6017CDC")]
		[Address(RVA = "0x1E29ABC", Offset = "0x1E29ABC", VA = "0x1E29ABC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018B2")]
	public bool Inherited
	{
		[Token(Token = "0x6017CDD")]
		[Address(RVA = "0x1E2A07C", Offset = "0x1E2A07C", VA = "0x1E2A07C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018B3")]
	public bool Hidden
	{
		[Token(Token = "0x6017CDE")]
		[Address(RVA = "0x1E2A19C", Offset = "0x1E2A19C", VA = "0x1E2A19C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017CDF")]
		[Address(RVA = "0x1E2A2B4", Offset = "0x1E2A2B4", VA = "0x1E2A2B4")]
		set
		{
		}
	}

	[Token(Token = "0x6017CD2")]
	[Address(RVA = "0x1E2995C", Offset = "0x1E2995C", VA = "0x1E2995C")]
	public BaseExposedData()
	{
	}

	[Token(Token = "0x6017CD3")]
	[Address(RVA = "0x1E29A1C", Offset = "0x1E29A1C", VA = "0x1E29A1C", Slot = "6")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6017CD4")]
	[Address(RVA = "0x1E29A20", Offset = "0x1E29A20", VA = "0x1E29A20", Slot = "7")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6017CD6")]
	[Address(RVA = "0x1E29BC8", Offset = "0x1E29BC8", VA = "0x1E29BC8")]
	public float GetOrder(bool next)
	{
		return default(float);
	}

	[Token(Token = "0x6017CD7")]
	[Address(RVA = "0x1E29C88", Offset = "0x1E29C88", VA = "0x1E29C88", Slot = "8")]
	public virtual BaseExposedData Clone()
	{
		return null;
	}

	[Token(Token = "0x6017CE0")]
	[Address(RVA = "0x1E2A418", Offset = "0x1E2A418", VA = "0x1E2A418")]
	private bool _003Cget_Children_003Em__0(BaseExposedData item)
	{
		return default(bool);
	}
}
