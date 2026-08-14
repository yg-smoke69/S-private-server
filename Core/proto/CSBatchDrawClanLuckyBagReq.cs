using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200164D")]
public class CSBatchDrawClanLuckyBagReq
{
	[Token(Token = "0x40095DC")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x40095DD")]
	[FieldOffset(Offset = "0x10")]
	public List<ClanLuckyBagInfo> bag_infos;

	[Token(Token = "0x6007C97")]
	[Address(RVA = "0x317DD60", Offset = "0x317DD60", VA = "0x317DD60")]
	public CSBatchDrawClanLuckyBagReq()
	{
	}
}
