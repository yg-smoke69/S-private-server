using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CAD")]
public class LockCupTeamReq
{
	[Token(Token = "0x400B58A")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Ccup_team_id_003Ek__BackingField;

	[Token(Token = "0x400B58B")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Ccup_type_003Ek__BackingField;

	[Token(Token = "0x400B58C")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Ccup_id_003Ek__BackingField;

	[Token(Token = "0x17000AB2")]
	public ulong cup_team_id
	{
		[Token(Token = "0x600847E")]
		[Address(RVA = "0x33EC4E8", Offset = "0x33EC4E8", VA = "0x33EC4E8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600847F")]
		[Address(RVA = "0x33EC4F0", Offset = "0x33EC4F0", VA = "0x33EC4F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000AB3")]
	public uint cup_type
	{
		[Token(Token = "0x6008480")]
		[Address(RVA = "0x33EC500", Offset = "0x33EC500", VA = "0x33EC500")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008481")]
		[Address(RVA = "0x33EC508", Offset = "0x33EC508", VA = "0x33EC508")]
		set
		{
		}
	}

	[Token(Token = "0x17000AB4")]
	public uint cup_id
	{
		[Token(Token = "0x6008482")]
		[Address(RVA = "0x33EC510", Offset = "0x33EC510", VA = "0x33EC510")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008483")]
		[Address(RVA = "0x33EC518", Offset = "0x33EC518", VA = "0x33EC518")]
		set
		{
		}
	}

	[Token(Token = "0x600847D")]
	[Address(RVA = "0x33EC4E0", Offset = "0x33EC4E0", VA = "0x33EC4E0")]
	public LockCupTeamReq()
	{
	}
}
