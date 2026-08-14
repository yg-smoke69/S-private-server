using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002D1D")]
public interface ILayoutTableItem
{
	[Token(Token = "0x6012DCC")]
	Vector2 GetSize();

	[Token(Token = "0x6012DCD")]
	void Init();

	[Token(Token = "0x6012DCE")]
	void UnInit();

	[Token(Token = "0x6012DCF")]
	bool SkipPadding();
}
