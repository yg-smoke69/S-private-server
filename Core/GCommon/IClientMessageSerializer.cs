using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004051")]
public interface IClientMessageSerializer
{
	[Token(Token = "0x601A2C8")]
	void Serialize(FastBinaryWriter writer);

	[Token(Token = "0x601A2C9")]
	void UnSerialize(FastBinaryReader reader);
}
