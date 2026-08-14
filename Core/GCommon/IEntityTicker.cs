using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003ED7")]
internal interface IEntityTicker
{
	[Token(Token = "0x6019950")]
	void OnFixedUpdate(float gameTime, float deltaTime);

	[Token(Token = "0x6019951")]
	void OnUpdate(float gameTime, float deltaTime);

	[Token(Token = "0x6019952")]
	void OnPaused();

	[Token(Token = "0x6019953")]
	void OnResumed();
}
