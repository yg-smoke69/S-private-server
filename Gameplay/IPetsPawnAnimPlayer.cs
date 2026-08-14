using Il2CppDummyDll;
using message;

[Token(Token = "0x2000890")]
internal interface IPetsPawnAnimPlayer
{
	[Token(Token = "0x6003C0F")]
	void PlayAnim(string animName, float speed = 1f);

	[Token(Token = "0x6003C10")]
	void PlayAnim(ODFIIFHKNNG petAction);
}
