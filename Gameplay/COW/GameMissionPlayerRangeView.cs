using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A8D")]
public class GameMissionPlayerRangeView : MonoBehaviour
{
	[Token(Token = "0x4018E76")]
	[FieldOffset(Offset = "0xC")]
	public Transform WantedPlayerRange;

	[Token(Token = "0x4018E77")]
	[FieldOffset(Offset = "0x10")]
	public UISprite Range;

	[Token(Token = "0x601734D")]
	[Address(RVA = "0x1DD575C", Offset = "0x1DD575C", VA = "0x1DD575C")]
	public GameMissionPlayerRangeView()
	{
	}
}
