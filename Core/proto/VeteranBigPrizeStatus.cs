using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A11")]
public class VeteranBigPrizeStatus
{
	[Token(Token = "0x400A378")]
	[FieldOffset(Offset = "0x8")]
	public List<VeteranBigPrizeIndexStatus> big_prize_status;

	[Token(Token = "0x6008069")]
	[Address(RVA = "0x33E44FC", Offset = "0x33E44FC", VA = "0x33E44FC")]
	public VeteranBigPrizeStatus()
	{
	}
}
