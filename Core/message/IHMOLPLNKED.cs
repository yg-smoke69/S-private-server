using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200118C")]
internal class IHMOLPLNKED : UDPClientMessageBase
{
	[Token(Token = "0x4007F1C")]
	[FieldOffset(Offset = "0xC")]
	public List<CINHMDGPFJI> MBGIKENODJD;

	[Token(Token = "0x6007416")]
	[Address(RVA = "0x361AECC", Offset = "0x361AECC", VA = "0x361AECC")]
	public IHMOLPLNKED()
	{
	}

	[Token(Token = "0x6007417")]
	[Address(RVA = "0x361AF50", Offset = "0x361AF50", VA = "0x361AF50", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007418")]
	[Address(RVA = "0x361B140", Offset = "0x361B140", VA = "0x361B140", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007419")]
	[Address(RVA = "0x361B300", Offset = "0x361B300", VA = "0x361B300", Slot = "9")]
	public override void Recycle()
	{
	}
}
