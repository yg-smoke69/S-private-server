using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017E1")]
public class CSGetLimitedEventStoreReq
{
	[Token(Token = "0x4009B99")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x4009B9A")]
	[FieldOffset(Offset = "0xC")]
	public uint store_type;

	[Token(Token = "0x6007E3B")]
	[Address(RVA = "0x3186D18", Offset = "0x3186D18", VA = "0x3186D18")]
	public CSGetLimitedEventStoreReq()
	{
	}
}
