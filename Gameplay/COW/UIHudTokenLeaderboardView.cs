using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003777")]
public class UIHudTokenLeaderboardView : UIBaseView
{
	[Token(Token = "0x401677C")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid ItemListGridMyTeam;

	[Token(Token = "0x401677D")]
	[FieldOffset(Offset = "0x18")]
	public Transform ItemListGridMyTeamTF;

	[Token(Token = "0x401677E")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite MyFactionIcon;

	[Token(Token = "0x401677F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel MyFactionName;

	[Token(Token = "0x4016780")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid ItemListGridEnemyTeam;

	[Token(Token = "0x4016781")]
	[FieldOffset(Offset = "0x28")]
	public Transform ItemListGridEnemyTeamTF;

	[Token(Token = "0x4016782")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite EnemyFactionIcon;

	[Token(Token = "0x4016783")]
	[FieldOffset(Offset = "0x30")]
	public UILabel EnemyFactionName;

	[Token(Token = "0x4016784")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnClose;

	[Token(Token = "0x6016A10")]
	[Address(RVA = "0x15833B8", Offset = "0x15833B8", VA = "0x15833B8")]
	public UIHudTokenLeaderboardView()
	{
	}

	[Token(Token = "0x6016A11")]
	[Address(RVA = "0x15833C0", Offset = "0x15833C0", VA = "0x15833C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A12")]
	[Address(RVA = "0x1583818", Offset = "0x1583818", VA = "0x1583818")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
