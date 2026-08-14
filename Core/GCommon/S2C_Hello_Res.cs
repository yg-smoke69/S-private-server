using System.IO;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200409C")]
internal class S2C_Hello_Res
{
	[Token(Token = "0x401B248")]
	[FieldOffset(Offset = "0x8")]
	public string SessionKey;

	[Token(Token = "0x401B249")]
	[FieldOffset(Offset = "0xC")]
	public ushort OrderID;

	[Token(Token = "0x401B24A")]
	[FieldOffset(Offset = "0xE")]
	public ushort RequiredID;

	[Token(Token = "0x401B24B")]
	[FieldOffset(Offset = "0x10")]
	public bool EnableFastProto;

	[Token(Token = "0x601A4B5")]
	[Address(RVA = "0x3230D9C", Offset = "0x3230D9C", VA = "0x3230D9C")]
	public S2C_Hello_Res()
	{
	}

	[Token(Token = "0x601A4B6")]
	[Address(RVA = "0x3230DA4", Offset = "0x3230DA4", VA = "0x3230DA4")]
	public void UnSerialize(BinaryReader reader)
	{
	}
}
