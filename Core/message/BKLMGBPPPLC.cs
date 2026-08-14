using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000EBE")]
internal class BKLMGBPPPLC : UDPClientMessageBase
{
	[Token(Token = "0x400784E")]
	[FieldOffset(Offset = "0xC")]
	public FNLOIELKGFH FOFJEMOKAOH;

	[Token(Token = "0x400784F")]
	[FieldOffset(Offset = "0x10")]
	public uint CEDJCPLOLNE;

	[Token(Token = "0x4007850")]
	[FieldOffset(Offset = "0x14")]
	public List<byte> IDOGLBBBAIC;

	[Token(Token = "0x4007851")]
	[FieldOffset(Offset = "0x18")]
	public List<byte> FFJMAEENIBO;

	[Token(Token = "0x60068D4")]
	[Address(RVA = "0x3748174", Offset = "0x3748174", VA = "0x3748174")]
	public BKLMGBPPPLC()
	{
	}

	[Token(Token = "0x60068D5")]
	[Address(RVA = "0x37481F8", Offset = "0x37481F8", VA = "0x37481F8", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60068D6")]
	[Address(RVA = "0x3748620", Offset = "0x3748620", VA = "0x3748620", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60068D7")]
	[Address(RVA = "0x37488A8", Offset = "0x37488A8", VA = "0x37488A8", Slot = "9")]
	public override void Recycle()
	{
	}
}
