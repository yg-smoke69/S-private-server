using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001907")]
public class CSGetVipCardDescRes
{
	[Token(Token = "0x4009E91")]
	[FieldOffset(Offset = "0x8")]
	public List<VipCardDailyAwardDesc> daily_awards;

	[Token(Token = "0x4009E92")]
	[FieldOffset(Offset = "0xC")]
	public List<VipCardInitAwardDesc> init_awards;

	[Token(Token = "0x4009E93")]
	[FieldOffset(Offset = "0x10")]
	public List<VipCardDesc> descs;

	[Token(Token = "0x4009E94")]
	[FieldOffset(Offset = "0x14")]
	public List<VipCardShowAwardDesc> show_awards;

	[Token(Token = "0x4009E95")]
	[FieldOffset(Offset = "0x18")]
	public List<VipCardRebateDesc> rebates;

	[Token(Token = "0x6007F60")]
	[Address(RVA = "0x3096340", Offset = "0x3096340", VA = "0x3096340")]
	public CSGetVipCardDescRes()
	{
	}
}
