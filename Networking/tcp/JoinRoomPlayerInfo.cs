using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D55")]
public class JoinRoomPlayerInfo
{
	[Token(Token = "0x400B94F")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cconn_id_003Ek__BackingField;

	[Token(Token = "0x400B950")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cemulator_score_003Ek__BackingField;

	[Token(Token = "0x400B951")]
	[FieldOffset(Offset = "0x14")]
	private AccountMatchInfo _003Cbasic_info_003Ek__BackingField;

	[Token(Token = "0x400B952")]
	[FieldOffset(Offset = "0x18")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B953")]
	[FieldOffset(Offset = "0x1C")]
	private string _003Ccountry_code_003Ek__BackingField;

	[Token(Token = "0x400B954")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cusing_version_003Ek__BackingField;

	[Token(Token = "0x17000C8F")]
	public ulong conn_id
	{
		[Token(Token = "0x60088AB")]
		[Address(RVA = "0x33EC06C", Offset = "0x33EC06C", VA = "0x33EC06C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088AC")]
		[Address(RVA = "0x33EC074", Offset = "0x33EC074", VA = "0x33EC074")]
		set
		{
		}
	}

	[Token(Token = "0x17000C90")]
	public uint emulator_score
	{
		[Token(Token = "0x60088AD")]
		[Address(RVA = "0x33EC084", Offset = "0x33EC084", VA = "0x33EC084")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088AE")]
		[Address(RVA = "0x33EC08C", Offset = "0x33EC08C", VA = "0x33EC08C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C91")]
	public AccountMatchInfo basic_info
	{
		[Token(Token = "0x60088AF")]
		[Address(RVA = "0x33EC094", Offset = "0x33EC094", VA = "0x33EC094")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088B0")]
		[Address(RVA = "0x33EC09C", Offset = "0x33EC09C", VA = "0x33EC09C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C92")]
	public uint[] available_maps
	{
		[Token(Token = "0x60088B1")]
		[Address(RVA = "0x33EC0A4", Offset = "0x33EC0A4", VA = "0x33EC0A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088B2")]
		[Address(RVA = "0x33EC0AC", Offset = "0x33EC0AC", VA = "0x33EC0AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000C93")]
	public string country_code
	{
		[Token(Token = "0x60088B3")]
		[Address(RVA = "0x33EC0B4", Offset = "0x33EC0B4", VA = "0x33EC0B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088B4")]
		[Address(RVA = "0x33EC064", Offset = "0x33EC064", VA = "0x33EC064")]
		set
		{
		}
	}

	[Token(Token = "0x17000C94")]
	public uint using_version
	{
		[Token(Token = "0x60088B5")]
		[Address(RVA = "0x33EC0BC", Offset = "0x33EC0BC", VA = "0x33EC0BC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088B6")]
		[Address(RVA = "0x33EC0C4", Offset = "0x33EC0C4", VA = "0x33EC0C4")]
		set
		{
		}
	}

	[Token(Token = "0x60088AA")]
	[Address(RVA = "0x33EBFC4", Offset = "0x33EBFC4", VA = "0x33EBFC4")]
	public JoinRoomPlayerInfo()
	{
	}
}
