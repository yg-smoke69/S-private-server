using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018D7")]
public class CSGetBooyahday21SettingRes
{
	[Token(Token = "0x4009DEF")]
	[FieldOffset(Offset = "0x8")]
	public Booyahday21SettingDesc setting;

	[Token(Token = "0x4009DF0")]
	[FieldOffset(Offset = "0xC")]
	public List<Booyahday21ProcessRewardDesc> process_reward_info;

	[Token(Token = "0x4009DF1")]
	[FieldOffset(Offset = "0x10")]
	public List<BISIntroDesc> bis_intro_info;

	[Token(Token = "0x4009DF2")]
	[FieldOffset(Offset = "0x14")]
	public List<BigEventProcessSettingDesc> bis_event_process;

	[Token(Token = "0x6007F30")]
	[Address(RVA = "0x31826E4", Offset = "0x31826E4", VA = "0x31826E4")]
	public CSGetBooyahday21SettingRes()
	{
	}
}
