using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040A4")]
internal class UDPMsgPacketResendInfo
{
	[Token(Token = "0x401B281")]
	[FieldOffset(Offset = "0x8")]
	public int ResendCount;

	[Token(Token = "0x401B282")]
	[FieldOffset(Offset = "0x10")]
	public double ResendTimeRatio;

	[Token(Token = "0x401B283")]
	[FieldOffset(Offset = "0x18")]
	public List<ushort> HistorySequenceIDs;

	[Token(Token = "0x601A4D0")]
	[Address(RVA = "0x32449D4", Offset = "0x32449D4", VA = "0x32449D4")]
	public UDPMsgPacketResendInfo()
	{
	}
}
