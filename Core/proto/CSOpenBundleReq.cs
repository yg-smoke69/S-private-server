using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A9")]
public class CSOpenBundleReq
{
	[Token(Token = "0x40093DB")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x40093DC")]
	[FieldOffset(Offset = "0x10")]
	public ulong room_id;

	[Token(Token = "0x6007BF1")]
	[Address(RVA = "0x309815C", Offset = "0x309815C", VA = "0x309815C")]
	public CSOpenBundleReq()
	{
	}
}
