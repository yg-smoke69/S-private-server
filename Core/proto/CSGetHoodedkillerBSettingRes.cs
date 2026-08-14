using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200183A")]
public class CSGetHoodedkillerBSettingRes
{
	[Token(Token = "0x4009C65")]
	[FieldOffset(Offset = "0x8")]
	public HoodedkillerBSettingDesc setting;

	[Token(Token = "0x4009C66")]
	[FieldOffset(Offset = "0xC")]
	public List<HoodedkillerBMissionDesc> missions;

	[Token(Token = "0x4009C67")]
	[FieldOffset(Offset = "0x10")]
	public List<HoodedkillerBTargetResourceDesc> resources;

	[Token(Token = "0x4009C68")]
	[FieldOffset(Offset = "0x14")]
	public List<HoodedkillerBRewardDesc> rewards;

	[Token(Token = "0x6007E94")]
	[Address(RVA = "0x3185D6C", Offset = "0x3185D6C", VA = "0x3185D6C")]
	public CSGetHoodedkillerBSettingRes()
	{
	}
}
