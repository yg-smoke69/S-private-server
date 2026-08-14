using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D44")]
public interface ITipsDelegate
{
	[Token(Token = "0x6012F2D")]
	void OnTipsDataChange(ETipsType type, int num);
}
