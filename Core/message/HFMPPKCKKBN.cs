using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200122A")]
internal class HFMPPKCKKBN : UDPClientMessageBase
{
	[Token(Token = "0x40080A0")]
	[FieldOffset(Offset = "0xC")]
	public int APNNIJDMGGF;

	[Token(Token = "0x40080A1")]
	[FieldOffset(Offset = "0x10")]
	public List<string> BMAMCCMDOBB;

	[Token(Token = "0x600768E")]
	[Address(RVA = "0x360E328", Offset = "0x360E328", VA = "0x360E328")]
	public HFMPPKCKKBN()
	{
	}

	[Token(Token = "0x600768F")]
	[Address(RVA = "0x360E3AC", Offset = "0x360E3AC", VA = "0x360E3AC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007690")]
	[Address(RVA = "0x360E5A8", Offset = "0x360E5A8", VA = "0x360E5A8", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007691")]
	[Address(RVA = "0x360E6D0", Offset = "0x360E6D0", VA = "0x360E6D0", Slot = "9")]
	public override void Recycle()
	{
	}
}
