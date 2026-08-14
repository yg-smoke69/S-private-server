using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DA9")]
public class TokenCupMatchInfo
{
	[Token(Token = "0x400BBF8")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cteam_id_003Ek__BackingField;

	[Token(Token = "0x400BBF9")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Ccup_type_003Ek__BackingField;

	[Token(Token = "0x400BBFA")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Ccup_id_003Ek__BackingField;

	[Token(Token = "0x400BBFB")]
	[FieldOffset(Offset = "0x18")]
	private string _003Cteam_name_003Ek__BackingField;

	[Token(Token = "0x400BBFC")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Chead_pic_003Ek__BackingField;

	[Token(Token = "0x17000EA4")]
	public ulong team_id
	{
		[Token(Token = "0x6008D1D")]
		[Address(RVA = "0x435FA00", Offset = "0x435FA00", VA = "0x435FA00")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008D1E")]
		[Address(RVA = "0x435FA08", Offset = "0x435FA08", VA = "0x435FA08")]
		set
		{
		}
	}

	[Token(Token = "0x17000EA5")]
	public uint cup_type
	{
		[Token(Token = "0x6008D1F")]
		[Address(RVA = "0x435FA18", Offset = "0x435FA18", VA = "0x435FA18")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D20")]
		[Address(RVA = "0x435FA20", Offset = "0x435FA20", VA = "0x435FA20")]
		set
		{
		}
	}

	[Token(Token = "0x17000EA6")]
	public uint cup_id
	{
		[Token(Token = "0x6008D21")]
		[Address(RVA = "0x435FA28", Offset = "0x435FA28", VA = "0x435FA28")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D22")]
		[Address(RVA = "0x435FA30", Offset = "0x435FA30", VA = "0x435FA30")]
		set
		{
		}
	}

	[Token(Token = "0x17000EA7")]
	public string team_name
	{
		[Token(Token = "0x6008D23")]
		[Address(RVA = "0x435FA38", Offset = "0x435FA38", VA = "0x435FA38")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008D24")]
		[Address(RVA = "0x435F9F8", Offset = "0x435F9F8", VA = "0x435F9F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000EA8")]
	public uint head_pic
	{
		[Token(Token = "0x6008D25")]
		[Address(RVA = "0x435FA40", Offset = "0x435FA40", VA = "0x435FA40")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D26")]
		[Address(RVA = "0x435FA48", Offset = "0x435FA48", VA = "0x435FA48")]
		set
		{
		}
	}

	[Token(Token = "0x6008D1C")]
	[Address(RVA = "0x435F958", Offset = "0x435F958", VA = "0x435F958")]
	public TokenCupMatchInfo()
	{
	}
}
