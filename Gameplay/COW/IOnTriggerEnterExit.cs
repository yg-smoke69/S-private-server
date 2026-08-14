using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000809")]
public interface IOnTriggerEnterExit
{
	[Token(Token = "0x6003347")]
	void OnTriggerEnter(Collider other);

	[Token(Token = "0x6003348")]
	void OnTriggerExit(Collider other);
}
