using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010FA")]
internal class MIHOPNCEDEN : UDPClientMessageBase
{
	[Token(Token = "0x4007DE3")]
	[FieldOffset(Offset = "0x9")]
	public byte POBGKMDJMDC;

	[Token(Token = "0x4007DE4")]
	[FieldOffset(Offset = "0xC")]
	public float NJLNFIOFNNA;

	[Token(Token = "0x60071CD")]
	[Address(RVA = "0x344303C", Offset = "0x344303C", VA = "0x344303C")]
	public MIHOPNCEDEN()
	{
	}

	[Token(Token = "0x60071CE")]
	[Address(RVA = "0x34430C0", Offset = "0x34430C0", VA = "0x34430C0", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60071CF")]
	[Address(RVA = "0x344314C", Offset = "0x344314C", VA = "0x344314C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60071D0")]
	[Address(RVA = "0x3443180", Offset = "0x3443180", VA = "0x3443180", Slot = "9")]
	public override void Recycle()
	{
	}
}
