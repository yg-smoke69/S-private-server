using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003616")]
public class UIHudControlLeaderboardView : UIBaseView
{
	[Token(Token = "0x4015A44")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LeftTitle_1;

	[Token(Token = "0x4015A45")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LeftTitle_2;

	[Token(Token = "0x4015A46")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LeftTitle_3;

	[Token(Token = "0x4015A47")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ItemListGridMyTeam;

	[Token(Token = "0x4015A48")]
	[FieldOffset(Offset = "0x24")]
	public Transform ItemListGridMyTeamTF;

	[Token(Token = "0x4015A49")]
	[FieldOffset(Offset = "0x28")]
	public UISprite MyFactionIcon;

	[Token(Token = "0x4015A4A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel MyFactionName;

	[Token(Token = "0x4015A4B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel RightTitle_1;

	[Token(Token = "0x4015A4C")]
	[FieldOffset(Offset = "0x34")]
	public UILabel RightTitle_2;

	[Token(Token = "0x4015A4D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel RightTitle_3;

	[Token(Token = "0x4015A4E")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid ItemListGridEnemyTeam;

	[Token(Token = "0x4015A4F")]
	[FieldOffset(Offset = "0x40")]
	public Transform ItemListGridEnemyTeamTF;

	[Token(Token = "0x4015A50")]
	[FieldOffset(Offset = "0x44")]
	public UISprite EnemyFactionIcon;

	[Token(Token = "0x4015A51")]
	[FieldOffset(Offset = "0x48")]
	public UILabel EnemyFactionName;

	[Token(Token = "0x4015A52")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnClose;

	[Token(Token = "0x60165F1")]
	[Address(RVA = "0x1362914", Offset = "0x1362914", VA = "0x1362914")]
	public UIHudControlLeaderboardView()
	{
	}

	[Token(Token = "0x60165F2")]
	[Address(RVA = "0x136291C", Offset = "0x136291C", VA = "0x136291C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165F3")]
	[Address(RVA = "0x1362FB4", Offset = "0x1362FB4", VA = "0x1362FB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
