using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200168D")]
public class CSGetLinkSettingInfoRes
{
	[Token(Token = "0x4009668")]
	[FieldOffset(Offset = "0x8")]
	public LinkSettingDesc link_setting_desc;

	[Token(Token = "0x4009669")]
	[FieldOffset(Offset = "0xC")]
	public List<LinkExchangeDesc> link_exchange_desc;

	[Token(Token = "0x6007CD7")]
	[Address(RVA = "0x3186E40", Offset = "0x3186E40", VA = "0x3186E40")]
	public CSGetLinkSettingInfoRes()
	{
	}
}
