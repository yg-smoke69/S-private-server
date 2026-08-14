using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D6E")]
public class RoomCountDownNtf
{
	[Token(Token = "0x400B9EA")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ccount_down_seconds_003Ek__BackingField;

	[Token(Token = "0x17000D2A")]
	public uint count_down_seconds
	{
		[Token(Token = "0x60089FA")]
		[Address(RVA = "0x435DB7C", Offset = "0x435DB7C", VA = "0x435DB7C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60089FB")]
		[Address(RVA = "0x435DB84", Offset = "0x435DB84", VA = "0x435DB84")]
		set
		{
		}
	}

	[Token(Token = "0x60089F9")]
	[Address(RVA = "0x435DB74", Offset = "0x435DB74", VA = "0x435DB74")]
	public RoomCountDownNtf()
	{
	}
}
