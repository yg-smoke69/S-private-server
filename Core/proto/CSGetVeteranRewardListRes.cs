using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015F4")]
public class CSGetVeteranRewardListRes
{
	[Token(Token = "0x40094A1")]
	[FieldOffset(Offset = "0x8")]
	public bool is_veteran;

	[Token(Token = "0x40094A2")]
	[FieldOffset(Offset = "0xC")]
	public List<VeteranRewardItem> rewards;

	[Token(Token = "0x40094A3")]
	[FieldOffset(Offset = "0x10")]
	public bool is_claim_return_prize;

	[Token(Token = "0x40094A4")]
	[FieldOffset(Offset = "0x14")]
	public uint[] claim_bundle;

	[Token(Token = "0x40094A5")]
	[FieldOffset(Offset = "0x18")]
	public uint[] random_task;

	[Token(Token = "0x40094A6")]
	[FieldOffset(Offset = "0x1C")]
	public uint activeness;

	[Token(Token = "0x40094A7")]
	[FieldOffset(Offset = "0x20")]
	public uint repeated_task_count;

	[Token(Token = "0x40094A8")]
	[FieldOffset(Offset = "0x24")]
	public bool is_return_login;

	[Token(Token = "0x40094A9")]
	[FieldOffset(Offset = "0x28")]
	public uint[] confirm_bundle;

	[Token(Token = "0x6007C3E")]
	[Address(RVA = "0x3096148", Offset = "0x3096148", VA = "0x3096148")]
	public CSGetVeteranRewardListRes()
	{
	}
}
