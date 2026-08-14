using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003095")]
public class GiftStoreInfo
{
	[Token(Token = "0x4012797")]
	[FieldOffset(Offset = "0x8")]
	public CSGetGiftStoreRes m_GetGiftStoreRes;

	[Token(Token = "0x4012798")]
	[FieldOffset(Offset = "0xC")]
	public string m_StoreIcon;

	[Token(Token = "0x4012799")]
	[FieldOffset(Offset = "0x10")]
	public string m_StoreTab;

	[Token(Token = "0x60144F9")]
	[Address(RVA = "0x25919D0", Offset = "0x25919D0", VA = "0x25919D0")]
	public GiftStoreInfo()
	{
	}
}
