using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200159B")]
public class CSChooseBannerReq
{
	[Token(Token = "0x40093B3")]
	[FieldOffset(Offset = "0x8")]
	public uint banner_id;

	[Token(Token = "0x40093B4")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007BE3")]
	[Address(RVA = "0x317E2E4", Offset = "0x317E2E4", VA = "0x317E2E4")]
	public CSChooseBannerReq()
	{
	}
}
