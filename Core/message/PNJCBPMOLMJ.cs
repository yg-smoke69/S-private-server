using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200125F")]
internal class PNJCBPMOLMJ : UDPClientMessageBase
{
	[Token(Token = "0x4008109")]
	[FieldOffset(Offset = "0xC")]
	public MDCLINGOINF NCAOKEDLKDI;

	[Token(Token = "0x400810A")]
	[FieldOffset(Offset = "0x10")]
	public float DAFCPMCCEBL;

	[Token(Token = "0x400810B")]
	[FieldOffset(Offset = "0x14")]
	public List<uint> IPCIBPENHME;

	[Token(Token = "0x400810C")]
	[FieldOffset(Offset = "0x18")]
	public uint PCEBMKFBHKL;

	[Token(Token = "0x6007762")]
	[Address(RVA = "0x3178200", Offset = "0x3178200", VA = "0x3178200")]
	public PNJCBPMOLMJ()
	{
	}

	[Token(Token = "0x6007763")]
	[Address(RVA = "0x3178284", Offset = "0x3178284", VA = "0x3178284", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007764")]
	[Address(RVA = "0x3178504", Offset = "0x3178504", VA = "0x3178504", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007765")]
	[Address(RVA = "0x3178658", Offset = "0x3178658", VA = "0x3178658", Slot = "9")]
	public override void Recycle()
	{
	}
}
