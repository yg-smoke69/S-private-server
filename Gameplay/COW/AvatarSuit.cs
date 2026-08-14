using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DA6")]
public class AvatarSuit
{
	[Token(Token = "0x4011857")]
	[FieldOffset(Offset = "0x8")]
	public uint suitID;

	[Token(Token = "0x4011858")]
	[FieldOffset(Offset = "0xC")]
	public bool isDefault;

	[Token(Token = "0x4011859")]
	[FieldOffset(Offset = "0xD")]
	public bool hasOwnComplete;

	[Token(Token = "0x60131D3")]
	[Address(RVA = "0x234EB8C", Offset = "0x234EB8C", VA = "0x234EB8C")]
	public AvatarSuit()
	{
	}
}
