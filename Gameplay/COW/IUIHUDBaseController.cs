using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002443")]
public interface IUIHUDBaseController
{
	[Token(Token = "0x600CDB0")]
	void SetEntityID(string entityID);

	[Token(Token = "0x600CDB1")]
	void DestroyEntity();
}
