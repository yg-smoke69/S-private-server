using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001981")]
public class CSGetBigEventDailyCheckInSettingRes
{
	[Token(Token = "0x4009FFD")]
	[FieldOffset(Offset = "0x8")]
	public List<BigEventDailyCheckInSettingDesc> check_in_setting;

	[Token(Token = "0x6007FDA")]
	[Address(RVA = "0x318226C", Offset = "0x318226C", VA = "0x318226C")]
	public CSGetBigEventDailyCheckInSettingRes()
	{
	}
}
