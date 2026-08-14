using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200190A")]
public class VipCardInfo
{
	[Token(Token = "0x4009E9A")]
	[FieldOffset(Offset = "0x8")]
	public EVipCard.VipCardType card_type;

	[Token(Token = "0x4009E9B")]
	[FieldOffset(Offset = "0xC")]
	public uint start_time;

	[Token(Token = "0x4009E9C")]
	[FieldOffset(Offset = "0x10")]
	public uint end_time;

	[Token(Token = "0x4009E9D")]
	[FieldOffset(Offset = "0x14")]
	public List<VipCardAwardStatus> award_infos;

	[Token(Token = "0x4009E9E")]
	[FieldOffset(Offset = "0x18")]
	public uint last_period_start_time;

	[Token(Token = "0x4009E9F")]
	[FieldOffset(Offset = "0x1C")]
	public uint last_period_end_time;

	[Token(Token = "0x4009EA0")]
	[FieldOffset(Offset = "0x20")]
	public List<VipCardAwardStatus> last_period_award_infos;

	[Token(Token = "0x6007F63")]
	[Address(RVA = "0x33E4B70", Offset = "0x33E4B70", VA = "0x33E4B70")]
	public VipCardInfo()
	{
	}
}
