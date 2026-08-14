using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040A3")]
internal class UDPMsgPacketTrackingData
{
	[Token(Token = "0x401B27D")]
	[FieldOffset(Offset = "0x8")]
	public ushort SequenceID;

	[Token(Token = "0x401B27E")]
	[FieldOffset(Offset = "0x10")]
	public double Time;

	[Token(Token = "0x401B27F")]
	[FieldOffset(Offset = "0x18")]
	public double Timeout;

	[Token(Token = "0x401B280")]
	[FieldOffset(Offset = "0x20")]
	public UDPMsgPacket PendingMsg;

	[Token(Token = "0x601A4CF")]
	[Address(RVA = "0x32449DC", Offset = "0x32449DC", VA = "0x32449DC")]
	public UDPMsgPacketTrackingData()
	{
	}
}
