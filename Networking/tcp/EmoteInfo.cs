using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D8C")]
public class EmoteInfo
{
	[Token(Token = "0x400BA98")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cslot_id_003Ek__BackingField;

	[Token(Token = "0x400BA99")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cemote_id_003Ek__BackingField;

	[Token(Token = "0x17000D44")]
	public uint slot_id
	{
		[Token(Token = "0x6008A40")]
		[Address(RVA = "0x33E9258", Offset = "0x33E9258", VA = "0x33E9258")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A41")]
		[Address(RVA = "0x33E9260", Offset = "0x33E9260", VA = "0x33E9260")]
		set
		{
		}
	}

	[Token(Token = "0x17000D45")]
	public uint emote_id
	{
		[Token(Token = "0x6008A42")]
		[Address(RVA = "0x33E9268", Offset = "0x33E9268", VA = "0x33E9268")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A43")]
		[Address(RVA = "0x33E9270", Offset = "0x33E9270", VA = "0x33E9270")]
		set
		{
		}
	}

	[Token(Token = "0x6008A3F")]
	[Address(RVA = "0x33E9250", Offset = "0x33E9250", VA = "0x33E9250")]
	public EmoteInfo()
	{
	}
}
