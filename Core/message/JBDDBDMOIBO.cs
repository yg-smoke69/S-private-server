using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010FD")]
internal class JBDDBDMOIBO : UDPClientMessageBase
{
	[Token(Token = "0x4007DED")]
	[FieldOffset(Offset = "0xC")]
	public uint MNGMENBBAOK;

	[Token(Token = "0x60071D9")]
	[Address(RVA = "0x3673DBC", Offset = "0x3673DBC", VA = "0x3673DBC")]
	public JBDDBDMOIBO()
	{
	}

	[Token(Token = "0x60071DA")]
	[Address(RVA = "0x3673E40", Offset = "0x3673E40", VA = "0x3673E40", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60071DB")]
	[Address(RVA = "0x3673E9C", Offset = "0x3673E9C", VA = "0x3673E9C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60071DC")]
	[Address(RVA = "0x3673EB8", Offset = "0x3673EB8", VA = "0x3673EB8", Slot = "9")]
	public override void Recycle()
	{
	}
}
