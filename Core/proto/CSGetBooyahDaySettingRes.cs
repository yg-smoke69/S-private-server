using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001805")]
public class CSGetBooyahDaySettingRes
{
	[Token(Token = "0x4009BE4")]
	[FieldOffset(Offset = "0x8")]
	public BooyahDaySettingDesc setting;

	[Token(Token = "0x4009BE5")]
	[FieldOffset(Offset = "0xC")]
	public List<BigEventTokenTipsDesc> exchange_token_tips;

	[Token(Token = "0x4009BE6")]
	[FieldOffset(Offset = "0x10")]
	public List<BigEventTokenTipsDesc> sugar_token_tips;

	[Token(Token = "0x4009BE7")]
	[FieldOffset(Offset = "0x14")]
	public List<BooyahDayProcessRewardDesc> process_reward_info;

	[Token(Token = "0x4009BE8")]
	[FieldOffset(Offset = "0x18")]
	public List<BigEventProcessSettingDesc> process_setting;

	[Token(Token = "0x4009BE9")]
	[FieldOffset(Offset = "0x1C")]
	public List<BooyahDaySignInDesc> sign_in;

	[Token(Token = "0x6007E5F")]
	[Address(RVA = "0x318259C", Offset = "0x318259C", VA = "0x318259C")]
	public CSGetBooyahDaySettingRes()
	{
	}
}
