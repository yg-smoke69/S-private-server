using System.IO;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040A0")]
internal class C2S_LongTimeNoSee_Req
{
	[Token(Token = "0x401B250")]
	[FieldOffset(Offset = "0x8")]
	public string SessionKey;

	[Token(Token = "0x601A4C1")]
	[Address(RVA = "0x307DEC8", Offset = "0x307DEC8", VA = "0x307DEC8")]
	public C2S_LongTimeNoSee_Req()
	{
	}

	[Token(Token = "0x601A4C2")]
	[Address(RVA = "0x307DED0", Offset = "0x307DED0", VA = "0x307DED0")]
	public void Serialize(BinaryWriter writer)
	{
	}
}
