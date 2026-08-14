using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000ECE")]
internal class CEJMAIHOFMM : UDPClientMessageBase
{
	[Token(Token = "0x400786E")]
	[FieldOffset(Offset = "0xC")]
	public int EGOMKONIBMP;

	[Token(Token = "0x400786F")]
	[FieldOffset(Offset = "0x10")]
	public List<CIBBLFMOMLK> HGMACOCMDMI;

	[Token(Token = "0x4007870")]
	[FieldOffset(Offset = "0x14")]
	public bool CIILMLJIDBJ;

	[Token(Token = "0x4007871")]
	[FieldOffset(Offset = "0x18")]
	public uint CEDJCPLOLNE;

	[Token(Token = "0x6006914")]
	[Address(RVA = "0x3750F38", Offset = "0x3750F38", VA = "0x3750F38")]
	public CEJMAIHOFMM()
	{
	}

	[Token(Token = "0x6006915")]
	[Address(RVA = "0x3750FBC", Offset = "0x3750FBC", VA = "0x3750FBC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006916")]
	[Address(RVA = "0x375123C", Offset = "0x375123C", VA = "0x375123C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006917")]
	[Address(RVA = "0x375143C", Offset = "0x375143C", VA = "0x375143C", Slot = "9")]
	public override void Recycle()
	{
	}

	[Token(Token = "0x6006918")]
	[Address(RVA = "0x3751584", Offset = "0x3751584", VA = "0x3751584", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
