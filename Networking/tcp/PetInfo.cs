using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D95")]
public class PetInfo
{
	[Token(Token = "0x400BAAF")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400BAB0")]
	[FieldOffset(Offset = "0xC")]
	private string _003Cname_003Ek__BackingField;

	[Token(Token = "0x400BAB1")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Clevel_003Ek__BackingField;

	[Token(Token = "0x400BAB2")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cexp_003Ek__BackingField;

	[Token(Token = "0x400BAB3")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cskin_id_003Ek__BackingField;

	[Token(Token = "0x400BAB4")]
	[FieldOffset(Offset = "0x1C")]
	private uint[] _003Cactions_003Ek__BackingField;

	[Token(Token = "0x400BAB5")]
	[FieldOffset(Offset = "0x20")]
	private List<PetSkillInfo> _003Cskills_003Ek__BackingField;

	[Token(Token = "0x17000D5B")]
	public uint id
	{
		[Token(Token = "0x6008A77")]
		[Address(RVA = "0x435CC28", Offset = "0x435CC28", VA = "0x435CC28")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A78")]
		[Address(RVA = "0x435CC30", Offset = "0x435CC30", VA = "0x435CC30")]
		set
		{
		}
	}

	[Token(Token = "0x17000D5C")]
	public string name
	{
		[Token(Token = "0x6008A79")]
		[Address(RVA = "0x435CC38", Offset = "0x435CC38", VA = "0x435CC38")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A7A")]
		[Address(RVA = "0x435CC18", Offset = "0x435CC18", VA = "0x435CC18")]
		set
		{
		}
	}

	[Token(Token = "0x17000D5D")]
	public uint level
	{
		[Token(Token = "0x6008A7B")]
		[Address(RVA = "0x435CC40", Offset = "0x435CC40", VA = "0x435CC40")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A7C")]
		[Address(RVA = "0x435CC48", Offset = "0x435CC48", VA = "0x435CC48")]
		set
		{
		}
	}

	[Token(Token = "0x17000D5E")]
	public uint exp
	{
		[Token(Token = "0x6008A7D")]
		[Address(RVA = "0x435CC50", Offset = "0x435CC50", VA = "0x435CC50")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A7E")]
		[Address(RVA = "0x435CC58", Offset = "0x435CC58", VA = "0x435CC58")]
		set
		{
		}
	}

	[Token(Token = "0x17000D5F")]
	public uint skin_id
	{
		[Token(Token = "0x6008A7F")]
		[Address(RVA = "0x435CC60", Offset = "0x435CC60", VA = "0x435CC60")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A80")]
		[Address(RVA = "0x435CC68", Offset = "0x435CC68", VA = "0x435CC68")]
		set
		{
		}
	}

	[Token(Token = "0x17000D60")]
	public uint[] actions
	{
		[Token(Token = "0x6008A81")]
		[Address(RVA = "0x435CC70", Offset = "0x435CC70", VA = "0x435CC70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A82")]
		[Address(RVA = "0x435CC78", Offset = "0x435CC78", VA = "0x435CC78")]
		set
		{
		}
	}

	[Token(Token = "0x17000D61")]
	public List<PetSkillInfo> skills
	{
		[Token(Token = "0x6008A83")]
		[Address(RVA = "0x435CC80", Offset = "0x435CC80", VA = "0x435CC80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A84")]
		[Address(RVA = "0x435CC20", Offset = "0x435CC20", VA = "0x435CC20")]
		private set
		{
		}
	}

	[Token(Token = "0x6008A76")]
	[Address(RVA = "0x435CB44", Offset = "0x435CB44", VA = "0x435CB44")]
	public PetInfo()
	{
	}
}
