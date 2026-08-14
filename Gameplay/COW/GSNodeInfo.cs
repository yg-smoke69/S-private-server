using System.Collections.Generic;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002FCE")]
internal class GSNodeInfo
{
	[Token(Token = "0x401232C")]
	[FieldOffset(Offset = "0x8")]
	public string IDC;

	[Token(Token = "0x401232D")]
	[FieldOffset(Offset = "0xC")]
	public int Ping_Time;

	[Token(Token = "0x401232E")]
	[FieldOffset(Offset = "0x10")]
	public List<string> IP_List;

	[Token(Token = "0x6013F8C")]
	[Address(RVA = "0x105076C", Offset = "0x105076C", VA = "0x105076C")]
	public GSNodeInfo()
	{
	}

	[Token(Token = "0x6013F8D")]
	[Address(RVA = "0x1050774", Offset = "0x1050774", VA = "0x1050774")]
	public static implicit operator AccountIDCPingInfo(GSNodeInfo info)
	{
		return null;
	}
}
