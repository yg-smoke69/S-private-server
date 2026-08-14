using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C18")]
public class BigEventDailyCheckInSettingDesc
{
	[Token(Token = "0x400B0D1")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x400B0D2")]
	[FieldOffset(Offset = "0xC")]
	public uint login_day_num;

	[Token(Token = "0x400B0D3")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400B0D4")]
	[FieldOffset(Offset = "0x14")]
	public string show_login_story;

	[Token(Token = "0x400B0D5")]
	[FieldOffset(Offset = "0x18")]
	public bool is_grand_award;

	[Token(Token = "0x6008272")]
	[Address(RVA = "0x317BD88", Offset = "0x317BD88", VA = "0x317BD88")]
	public BigEventDailyCheckInSettingDesc()
	{
	}
}
