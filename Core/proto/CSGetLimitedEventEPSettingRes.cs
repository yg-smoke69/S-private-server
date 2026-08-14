using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001864")]
public class CSGetLimitedEventEPSettingRes
{
	[Token(Token = "0x4009CE7")]
	[FieldOffset(Offset = "0x8")]
	public BigEventPassSettingDesc setting_desc;

	[Token(Token = "0x4009CE8")]
	[FieldOffset(Offset = "0xC")]
	public List<BigEventPassRewardDesc> reward_descs;

	[Token(Token = "0x6007EBD")]
	[Address(RVA = "0x3186A08", Offset = "0x3186A08", VA = "0x3186A08")]
	public CSGetLimitedEventEPSettingRes()
	{
	}
}
