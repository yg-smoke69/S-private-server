using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200118E")]
internal class CNGABMICKPB : UDPClientMessageBase
{
	[Token(Token = "0x4007F1F")]
	[FieldOffset(Offset = "0xC")]
	public OOIIAFEFOLC MMJMADPFKIF;

	[Token(Token = "0x4007F20")]
	[FieldOffset(Offset = "0x10")]
	public List<BKOLJKNLBBM> OICIKGFHMAI;

	[Token(Token = "0x4007F21")]
	[FieldOffset(Offset = "0x14")]
	public uint HDHNBOAADGA;

	[Token(Token = "0x600741E")]
	[Address(RVA = "0x375917C", Offset = "0x375917C", VA = "0x375917C")]
	public CNGABMICKPB()
	{
	}

	[Token(Token = "0x600741F")]
	[Address(RVA = "0x3759200", Offset = "0x3759200", VA = "0x3759200", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007420")]
	[Address(RVA = "0x3759444", Offset = "0x3759444", VA = "0x3759444", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007421")]
	[Address(RVA = "0x3759630", Offset = "0x3759630", VA = "0x3759630", Slot = "9")]
	public override void Recycle()
	{
	}
}
