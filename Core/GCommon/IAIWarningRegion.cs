using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20005A2")]
public interface IAIWarningRegion
{
	[Token(Token = "0x170002D3")]
	Transform transform
	{
		[Token(Token = "0x600224C")]
		get;
	}

	[Token(Token = "0x6002249")]
	void OnInit();

	[Token(Token = "0x600224A")]
	void OnRecycle();

	[Token(Token = "0x600224B")]
	GameObject GetGameObject();
}
