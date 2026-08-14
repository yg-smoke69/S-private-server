using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E86")]
public interface IObjectPoolCallback
{
	[Token(Token = "0x6019719")]
	void OnAllocated();

	[Token(Token = "0x601971A")]
	void OnCollected();

	[Token(Token = "0x601971B")]
	bool IsInPool();
}
