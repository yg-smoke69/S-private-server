using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CA7")]
public class ConfirmAddCupTeamReq
{
	[Token(Token = "0x400B56B")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Ccup_team_id_003Ek__BackingField;

	[Token(Token = "0x400B56C")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cconfirmer_id_003Ek__BackingField;

	[Token(Token = "0x400B56D")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Ccup_type_003Ek__BackingField;

	[Token(Token = "0x400B56E")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Ccup_id_003Ek__BackingField;

	[Token(Token = "0x17000A93")]
	public ulong cup_team_id
	{
		[Token(Token = "0x600843A")]
		[Address(RVA = "0x33E8800", Offset = "0x33E8800", VA = "0x33E8800")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600843B")]
		[Address(RVA = "0x33E8808", Offset = "0x33E8808", VA = "0x33E8808")]
		set
		{
		}
	}

	[Token(Token = "0x17000A94")]
	public ulong confirmer_id
	{
		[Token(Token = "0x600843C")]
		[Address(RVA = "0x33E8818", Offset = "0x33E8818", VA = "0x33E8818")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600843D")]
		[Address(RVA = "0x33E8820", Offset = "0x33E8820", VA = "0x33E8820")]
		set
		{
		}
	}

	[Token(Token = "0x17000A95")]
	public uint cup_type
	{
		[Token(Token = "0x600843E")]
		[Address(RVA = "0x33E8830", Offset = "0x33E8830", VA = "0x33E8830")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600843F")]
		[Address(RVA = "0x33E8838", Offset = "0x33E8838", VA = "0x33E8838")]
		set
		{
		}
	}

	[Token(Token = "0x17000A96")]
	public uint cup_id
	{
		[Token(Token = "0x6008440")]
		[Address(RVA = "0x33E8840", Offset = "0x33E8840", VA = "0x33E8840")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008441")]
		[Address(RVA = "0x33E8848", Offset = "0x33E8848", VA = "0x33E8848")]
		set
		{
		}
	}

	[Token(Token = "0x6008439")]
	[Address(RVA = "0x33E87F8", Offset = "0x33E87F8", VA = "0x33E87F8")]
	public ConfirmAddCupTeamReq()
	{
	}
}
