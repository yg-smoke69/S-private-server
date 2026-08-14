using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200188C")]
public class FFWS03ManagerSetting
{
	[Token(Token = "0x4009D2D")]
	[FieldOffset(Offset = "0x8")]
	public List<FFWSCharacterDesc> character_desc;

	[Token(Token = "0x4009D2E")]
	[FieldOffset(Offset = "0xC")]
	public List<FFWSMatchRewardsDesc> match_rewards_desc;

	[Token(Token = "0x4009D2F")]
	[FieldOffset(Offset = "0x10")]
	public List<FFWSTargetDesc> target_desc;

	[Token(Token = "0x4009D30")]
	[FieldOffset(Offset = "0x14")]
	public List<FFWSMatchDesc> match_desc;

	[Token(Token = "0x4009D31")]
	[FieldOffset(Offset = "0x18")]
	public FFWSTrainDesc train_desc;

	[Token(Token = "0x6007EE5")]
	[Address(RVA = "0x30A0278", Offset = "0x30A0278", VA = "0x30A0278")]
	public FFWS03ManagerSetting()
	{
	}
}
