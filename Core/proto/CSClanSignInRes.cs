using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200163A")]
public class CSClanSignInRes
{
	[Token(Token = "0x400957B")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanSignInRewardItem> rewards;

	[Token(Token = "0x400957C")]
	[FieldOffset(Offset = "0xC")]
	public bool is_newcomer;

	[Token(Token = "0x6007C84")]
	[Address(RVA = "0x317EE48", Offset = "0x317EE48", VA = "0x317EE48")]
	public CSClanSignInRes()
	{
	}
}
