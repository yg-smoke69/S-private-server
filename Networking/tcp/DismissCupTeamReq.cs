using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CAB")]
public class DismissCupTeamReq
{
	[Token(Token = "0x400B57F")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Ccup_team_id_003Ek__BackingField;

	[Token(Token = "0x400B580")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cdismisser_id_003Ek__BackingField;

	[Token(Token = "0x400B581")]
	[FieldOffset(Offset = "0x18")]
	private string _003Ccup_team_name_003Ek__BackingField;

	[Token(Token = "0x400B582")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Ccup_type_003Ek__BackingField;

	[Token(Token = "0x400B583")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Ccup_id_003Ek__BackingField;

	[Token(Token = "0x17000AA7")]
	public ulong cup_team_id
	{
		[Token(Token = "0x6008466")]
		[Address(RVA = "0x33E8E84", Offset = "0x33E8E84", VA = "0x33E8E84")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008467")]
		[Address(RVA = "0x33E8E8C", Offset = "0x33E8E8C", VA = "0x33E8E8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA8")]
	public ulong dismisser_id
	{
		[Token(Token = "0x6008468")]
		[Address(RVA = "0x33E8E9C", Offset = "0x33E8E9C", VA = "0x33E8E9C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008469")]
		[Address(RVA = "0x33E8EA4", Offset = "0x33E8EA4", VA = "0x33E8EA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA9")]
	public string cup_team_name
	{
		[Token(Token = "0x600846A")]
		[Address(RVA = "0x33E8EB4", Offset = "0x33E8EB4", VA = "0x33E8EB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600846B")]
		[Address(RVA = "0x33E8E7C", Offset = "0x33E8E7C", VA = "0x33E8E7C")]
		set
		{
		}
	}

	[Token(Token = "0x17000AAA")]
	public uint cup_type
	{
		[Token(Token = "0x600846C")]
		[Address(RVA = "0x33E8EBC", Offset = "0x33E8EBC", VA = "0x33E8EBC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600846D")]
		[Address(RVA = "0x33E8EC4", Offset = "0x33E8EC4", VA = "0x33E8EC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000AAB")]
	public uint cup_id
	{
		[Token(Token = "0x600846E")]
		[Address(RVA = "0x33E8ECC", Offset = "0x33E8ECC", VA = "0x33E8ECC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600846F")]
		[Address(RVA = "0x33E8ED4", Offset = "0x33E8ED4", VA = "0x33E8ED4")]
		set
		{
		}
	}

	[Token(Token = "0x6008465")]
	[Address(RVA = "0x33E8DDC", Offset = "0x33E8DDC", VA = "0x33E8DDC")]
	public DismissCupTeamReq()
	{
	}
}
