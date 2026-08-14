using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017D2")]
public class CSGetVeteranTaskInfoRes
{
	[Token(Token = "0x4009B81")]
	[FieldOffset(Offset = "0x8")]
	public List<VeteranTaskInfo> tasks;

	[Token(Token = "0x4009B82")]
	[FieldOffset(Offset = "0xC")]
	public VeteranBigPrizeStatus big_prizes;

	[Token(Token = "0x6007E2C")]
	[Address(RVA = "0x30962A4", Offset = "0x30962A4", VA = "0x30962A4")]
	public CSGetVeteranTaskInfoRes()
	{
	}
}
