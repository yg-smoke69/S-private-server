using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001930")]
public class CSGetChummyStateRes
{
	[Token(Token = "0x4009F0D")]
	[FieldOffset(Offset = "0x8")]
	public List<AccountInfoWithChummyState> chummy_state;

	[Token(Token = "0x4009F0E")]
	[FieldOffset(Offset = "0xC")]
	public MentoringRelationInfo mentoring_info;

	[Token(Token = "0x6007F89")]
	[Address(RVA = "0x3182FA0", Offset = "0x3182FA0", VA = "0x3182FA0")]
	public CSGetChummyStateRes()
	{
	}
}
