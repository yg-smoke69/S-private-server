using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001879")]
public class CSGetMVPSettingRes
{
	[Token(Token = "0x4009D0E")]
	[FieldOffset(Offset = "0x8")]
	public MVPSettingDesc setting;

	[Token(Token = "0x4009D0F")]
	[FieldOffset(Offset = "0xC")]
	public List<MVPProcessRewardDesc> process_reward_info;

	[Token(Token = "0x6007ED2")]
	[Address(RVA = "0x31872F0", Offset = "0x31872F0", VA = "0x31872F0")]
	public CSGetMVPSettingRes()
	{
	}
}
