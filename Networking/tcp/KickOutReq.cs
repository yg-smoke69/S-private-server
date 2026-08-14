using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CD7")]
public class KickOutReq
{
	[Token(Token = "0x400B6BD")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Ckickout_id_003Ek__BackingField;

	[Token(Token = "0x17000B24")]
	public ulong kickout_id
	{
		[Token(Token = "0x600857A")]
		[Address(RVA = "0x33EC224", Offset = "0x33EC224", VA = "0x33EC224")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600857B")]
		[Address(RVA = "0x33EC22C", Offset = "0x33EC22C", VA = "0x33EC22C")]
		set
		{
		}
	}

	[Token(Token = "0x6008579")]
	[Address(RVA = "0x33EC21C", Offset = "0x33EC21C", VA = "0x33EC21C")]
	public KickOutReq()
	{
	}
}
