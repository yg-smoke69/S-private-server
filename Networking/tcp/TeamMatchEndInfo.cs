using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CAC")]
public class TeamMatchEndInfo
{
	[Token(Token = "0x400B584")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ccup_type_003Ek__BackingField;

	[Token(Token = "0x400B585")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Ccup_id_003Ek__BackingField;

	[Token(Token = "0x400B586")]
	[FieldOffset(Offset = "0x10")]
	private bool _003Cis_invalid_match_003Ek__BackingField;

	[Token(Token = "0x400B587")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Copponent_team_id_003Ek__BackingField;

	[Token(Token = "0x400B588")]
	[FieldOffset(Offset = "0x20")]
	private string _003Copponent_team_name_003Ek__BackingField;

	[Token(Token = "0x400B589")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Copponent_head_pic_003Ek__BackingField;

	[Token(Token = "0x17000AAC")]
	public uint cup_type
	{
		[Token(Token = "0x6008471")]
		[Address(RVA = "0x435F530", Offset = "0x435F530", VA = "0x435F530")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008472")]
		[Address(RVA = "0x435F538", Offset = "0x435F538", VA = "0x435F538")]
		set
		{
		}
	}

	[Token(Token = "0x17000AAD")]
	public uint cup_id
	{
		[Token(Token = "0x6008473")]
		[Address(RVA = "0x435F540", Offset = "0x435F540", VA = "0x435F540")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008474")]
		[Address(RVA = "0x435F548", Offset = "0x435F548", VA = "0x435F548")]
		set
		{
		}
	}

	[Token(Token = "0x17000AAE")]
	public bool is_invalid_match
	{
		[Token(Token = "0x6008475")]
		[Address(RVA = "0x435F550", Offset = "0x435F550", VA = "0x435F550")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008476")]
		[Address(RVA = "0x435F558", Offset = "0x435F558", VA = "0x435F558")]
		set
		{
		}
	}

	[Token(Token = "0x17000AAF")]
	public ulong opponent_team_id
	{
		[Token(Token = "0x6008477")]
		[Address(RVA = "0x435F560", Offset = "0x435F560", VA = "0x435F560")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008478")]
		[Address(RVA = "0x435F568", Offset = "0x435F568", VA = "0x435F568")]
		set
		{
		}
	}

	[Token(Token = "0x17000AB0")]
	public string opponent_team_name
	{
		[Token(Token = "0x6008479")]
		[Address(RVA = "0x435F578", Offset = "0x435F578", VA = "0x435F578")]
		get
		{
			return null;
		}
		[Token(Token = "0x600847A")]
		[Address(RVA = "0x435F528", Offset = "0x435F528", VA = "0x435F528")]
		set
		{
		}
	}

	[Token(Token = "0x17000AB1")]
	public uint opponent_head_pic
	{
		[Token(Token = "0x600847B")]
		[Address(RVA = "0x435F580", Offset = "0x435F580", VA = "0x435F580")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600847C")]
		[Address(RVA = "0x435F588", Offset = "0x435F588", VA = "0x435F588")]
		set
		{
		}
	}

	[Token(Token = "0x6008470")]
	[Address(RVA = "0x435F488", Offset = "0x435F488", VA = "0x435F488")]
	public TeamMatchEndInfo()
	{
	}
}
