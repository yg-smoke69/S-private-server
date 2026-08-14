using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003799")]
public class UIHUDUGC_MoreTeam_RoundScoreView : UIBaseView
{
	[Token(Token = "0x401685D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RankValue;

	[Token(Token = "0x401685E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ScoreValue;

	[Token(Token = "0x401685F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RankTitle;

	[Token(Token = "0x4016860")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ScoreTitle;

	[Token(Token = "0x6016A76")]
	[Address(RVA = "0x2E1B658", Offset = "0x2E1B658", VA = "0x2E1B658")]
	public UIHUDUGC_MoreTeam_RoundScoreView()
	{
	}

	[Token(Token = "0x6016A77")]
	[Address(RVA = "0x2E1B660", Offset = "0x2E1B660", VA = "0x2E1B660", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A78")]
	[Address(RVA = "0x2E1B928", Offset = "0x2E1B928", VA = "0x2E1B928")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
