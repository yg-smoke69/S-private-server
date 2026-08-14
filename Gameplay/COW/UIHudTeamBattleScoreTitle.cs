using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200236E")]
public class UIHudTeamBattleScoreTitle : MonoBehaviour
{
	[Token(Token = "0x400DC95")]
	[FieldOffset(Offset = "0xC")]
	public UILabel TitleInfoText1;

	[Token(Token = "0x400DC96")]
	[FieldOffset(Offset = "0x10")]
	public UILabel TitleInfoText2;

	[Token(Token = "0x400DC97")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TitleInfoText3;

	[Token(Token = "0x600C613")]
	[Address(RVA = "0x179CB8C", Offset = "0x179CB8C", VA = "0x179CB8C")]
	public UIHudTeamBattleScoreTitle()
	{
	}
}
