using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DC0")]
public class FreeRoomTimesChangeNtf
{
	[Token(Token = "0x400BC6C")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cgeneral_times_003Ek__BackingField;

	[Token(Token = "0x400BC6D")]
	[FieldOffset(Offset = "0xC")]
	private bool _003Crefresh_003Ek__BackingField;

	[Token(Token = "0x17000F03")]
	public uint general_times
	{
		[Token(Token = "0x6008DEC")]
		[Address(RVA = "0x33E92C0", Offset = "0x33E92C0", VA = "0x33E92C0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008DED")]
		[Address(RVA = "0x33E92C8", Offset = "0x33E92C8", VA = "0x33E92C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000F04")]
	public bool refresh
	{
		[Token(Token = "0x6008DEE")]
		[Address(RVA = "0x33E92D0", Offset = "0x33E92D0", VA = "0x33E92D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008DEF")]
		[Address(RVA = "0x33E92D8", Offset = "0x33E92D8", VA = "0x33E92D8")]
		set
		{
		}
	}

	[Token(Token = "0x6008DEB")]
	[Address(RVA = "0x33E92B8", Offset = "0x33E92B8", VA = "0x33E92B8")]
	public FreeRoomTimesChangeNtf()
	{
	}
}
