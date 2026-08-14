using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200193F")]
public class CSGetCreditScoreDescRes
{
	[Token(Token = "0x4009F3B")]
	[FieldOffset(Offset = "0x8")]
	public CreditSettingDesc credit_setting_desc;

	[Token(Token = "0x4009F3C")]
	[FieldOffset(Offset = "0xC")]
	public CreditSwitchDesc credit_switch_desc;

	[Token(Token = "0x4009F3D")]
	[FieldOffset(Offset = "0x10")]
	public List<CreditPunishDesc> credit_punish_desc;

	[Token(Token = "0x4009F3E")]
	[FieldOffset(Offset = "0x14")]
	public CreditAwardDesc credit_award_desc;

	[Token(Token = "0x4009F3F")]
	[FieldOffset(Offset = "0x18")]
	public List<CreditReduceDesc> credit_reduce_desc_list;

	[Token(Token = "0x6007F98")]
	[Address(RVA = "0x3183440", Offset = "0x3183440", VA = "0x3183440")]
	public CSGetCreditScoreDescRes()
	{
	}
}
