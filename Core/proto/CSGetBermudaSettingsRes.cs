using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001811")]
public class CSGetBermudaSettingsRes
{
	[Token(Token = "0x4009BFC")]
	[FieldOffset(Offset = "0x8")]
	public BermudaSettingsDesc bermuda_settings_desc;

	[Token(Token = "0x4009BFD")]
	[FieldOffset(Offset = "0xC")]
	public List<BermudaAwardDesc> bermuda_awards;

	[Token(Token = "0x4009BFE")]
	[FieldOffset(Offset = "0x10")]
	public List<BermudaIntroDesc> bermuda_intro_desc;

	[Token(Token = "0x6007E6B")]
	[Address(RVA = "0x3182194", Offset = "0x3182194", VA = "0x3182194")]
	public CSGetBermudaSettingsRes()
	{
	}
}
