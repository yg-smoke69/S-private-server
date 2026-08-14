using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016DD")]
public class CSGetActGachaInfoRes
{
	[Token(Token = "0x4009785")]
	[FieldOffset(Offset = "0x8")]
	public uint[] unlocked_pools;

	[Token(Token = "0x4009786")]
	[FieldOffset(Offset = "0xC")]
	public List<ActIds> act_ids;

	[Token(Token = "0x4009787")]
	[FieldOffset(Offset = "0x10")]
	public uint act_progress;

	[Token(Token = "0x4009788")]
	[FieldOffset(Offset = "0x14")]
	public uint[] exchanged_reward_list;

	[Token(Token = "0x6007D37")]
	[Address(RVA = "0x3180F38", Offset = "0x3180F38", VA = "0x3180F38")]
	public CSGetActGachaInfoRes()
	{
	}
}
