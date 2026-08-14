using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003692")]
public class UIHudLeaderboardView : UIBaseView
{
	[Token(Token = "0x4015F56")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid ItemListGridMyTeam;

	[Token(Token = "0x4015F57")]
	[FieldOffset(Offset = "0x18")]
	public Transform ItemListGridMyTeamTF;

	[Token(Token = "0x4015F58")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite MyFactionIcon;

	[Token(Token = "0x4015F59")]
	[FieldOffset(Offset = "0x20")]
	public UILabel MyFactionName;

	[Token(Token = "0x4015F5A")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid ItemListGridEnemyTeam;

	[Token(Token = "0x4015F5B")]
	[FieldOffset(Offset = "0x28")]
	public Transform ItemListGridEnemyTeamTF;

	[Token(Token = "0x4015F5C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite EnemyFactionIcon;

	[Token(Token = "0x4015F5D")]
	[FieldOffset(Offset = "0x30")]
	public UILabel EnemyFactionName;

	[Token(Token = "0x4015F5E")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnClose;

	[Token(Token = "0x6016763")]
	[Address(RVA = "0xFEC78C", Offset = "0xFEC78C", VA = "0xFEC78C")]
	public UIHudLeaderboardView()
	{
	}

	[Token(Token = "0x6016764")]
	[Address(RVA = "0xFEC794", Offset = "0xFEC794", VA = "0xFEC794", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016765")]
	[Address(RVA = "0xFECBEC", Offset = "0xFECBEC", VA = "0xFECBEC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
