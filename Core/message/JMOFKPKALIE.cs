using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F5F")]
internal class JMOFKPKALIE : UDPClientMessageBase
{
	[Token(Token = "0x4007A29")]
	[FieldOffset(Offset = "0xC")]
	public KIENBCKEALI PMGKCHFNPAK;

	[Token(Token = "0x4007A2A")]
	[FieldOffset(Offset = "0x10")]
	public List<KIENBCKEALI> POAIFIFIFLC;

	[Token(Token = "0x4007A2B")]
	[FieldOffset(Offset = "0x14")]
	public byte ECHAALFHDAE;

	[Token(Token = "0x6006B60")]
	[Address(RVA = "0x3680E68", Offset = "0x3680E68", VA = "0x3680E68")]
	public JMOFKPKALIE()
	{
	}

	[Token(Token = "0x6006B61")]
	[Address(RVA = "0x3680EEC", Offset = "0x3680EEC", VA = "0x3680EEC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006B62")]
	[Address(RVA = "0x36811B0", Offset = "0x36811B0", VA = "0x36811B0", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006B63")]
	[Address(RVA = "0x368140C", Offset = "0x368140C", VA = "0x368140C", Slot = "9")]
	public override void Recycle()
	{
	}
}
