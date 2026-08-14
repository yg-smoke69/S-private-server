using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001686")]
public class CSClaimDispatchQuestRewardsRes
{
	[Token(Token = "0x400965D")]
	[FieldOffset(Offset = "0x8")]
	public AvatarDispatchQuest avatar_dispatch_state;

	[Token(Token = "0x400965E")]
	[FieldOffset(Offset = "0xC")]
	public uint critical_times;

	[Token(Token = "0x400965F")]
	[FieldOffset(Offset = "0x10")]
	public List<ExchangedAward> exchangedAwards;

	[Token(Token = "0x6007CD0")]
	[Address(RVA = "0x317E5D0", Offset = "0x317E5D0", VA = "0x317E5D0")]
	public CSClaimDispatchQuestRewardsRes()
	{
	}
}
