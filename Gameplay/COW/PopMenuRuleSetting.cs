using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2003294")]
public class PopMenuRuleSetting : _Attribute
{
	[Serializable]
	[Token(Token = "0x2003295")]
	public class Item
	{
		[Token(Token = "0x4013433")]
		[FieldOffset(Offset = "0x8")]
		public string LabelID;

		[Token(Token = "0x4013434")]
		[FieldOffset(Offset = "0xC")]
		public int Value;

		[Token(Token = "0x6015542")]
		[Address(RVA = "0x1C0D9E0", Offset = "0x1C0D9E0", VA = "0x1C0D9E0")]
		public Item()
		{
		}
	}

	[Token(Token = "0x2003296")]
	private sealed class _003CFromProtoData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013435")]
		[FieldOffset(Offset = "0x8")]
		internal int value;

		[Token(Token = "0x6015543")]
		[Address(RVA = "0x1C0D6C0", Offset = "0x1C0D6C0", VA = "0x1C0D6C0")]
		public _003CFromProtoData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015544")]
		[Address(RVA = "0x1C0DA20", Offset = "0x1C0DA20", VA = "0x1C0DA20")]
		internal bool _003C_003Em__0(Item item)
		{
			return default(bool);
		}
	}

	[NonSerialized]
	[Token(Token = "0x401342D")]
	[FieldOffset(Offset = "0x8")]
	public int Value;

	[NonSerialized]
	[Token(Token = "0x401342E")]
	[FieldOffset(Offset = "0xC")]
	public bool Enabled;

	[Token(Token = "0x401342F")]
	[FieldOffset(Offset = "0x10")]
	public string TitleID;

	[Token(Token = "0x4013430")]
	[FieldOffset(Offset = "0x14")]
	public Item[] Items;

	[Token(Token = "0x4013431")]
	[FieldOffset(Offset = "0x18")]
	public int DefaultValue;

	[Token(Token = "0x4013432")]
	[FieldOffset(Offset = "0x1C")]
	public int Width;

	[Token(Token = "0x601553C")]
	[Address(RVA = "0x1C0D2E8", Offset = "0x1C0D2E8", VA = "0x1C0D2E8")]
	public PopMenuRuleSetting()
	{
	}

	[Token(Token = "0x601553D")]
	[Address(RVA = "0x1C0D2F0", Offset = "0x1C0D2F0", VA = "0x1C0D2F0")]
	public int ToProtoData()
	{
		return default(int);
	}

	[Token(Token = "0x601553E")]
	[Address(RVA = "0x1C0D4B8", Offset = "0x1C0D4B8", VA = "0x1C0D4B8")]
	public bool FromProtoData(int value)
	{
		return default(bool);
	}

	[Token(Token = "0x601553F")]
	[Address(RVA = "0x1C0D6C8", Offset = "0x1C0D6C8", VA = "0x1C0D6C8")]
	public void FromDefaultData()
	{
	}

	[Token(Token = "0x6015540")]
	[Address(RVA = "0x1C0D724", Offset = "0x1C0D724", VA = "0x1C0D724")]
	public PopMenuRuleSetting Clone()
	{
		return null;
	}

	[Token(Token = "0x6015541")]
	[Address(RVA = "0x1C0D9E8", Offset = "0x1C0D9E8", VA = "0x1C0D9E8")]
	private bool _003CToProtoData_003Em__0(Item item)
	{
		return default(bool);
	}
}
