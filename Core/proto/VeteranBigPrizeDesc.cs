using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A0F")]
public class VeteranBigPrizeDesc
{
	[Token(Token = "0x400A36F")]
	[FieldOffset(Offset = "0x8")]
	public uint big_prize_id;

	[Token(Token = "0x400A370")]
	[FieldOffset(Offset = "0xC")]
	public uint veteran_class;

	[Token(Token = "0x400A371")]
	[FieldOffset(Offset = "0x10")]
	public uint big_prize_demand;

	[Token(Token = "0x400A372")]
	[FieldOffset(Offset = "0x14")]
	public string cdn_url;

	[Token(Token = "0x400A373")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A374")]
	[FieldOffset(Offset = "0x1C")]
	public string language;

	[Token(Token = "0x400A375")]
	[FieldOffset(Offset = "0x20")]
	public uint big_prize_index;

	[Token(Token = "0x6008067")]
	[Address(RVA = "0x33E4404", Offset = "0x33E4404", VA = "0x33E4404")]
	public VeteranBigPrizeDesc()
	{
	}
}
