using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D4")]
public class UISPHudResultTopLiteTeamItemView : UIBaseView
{
	[Token(Token = "0x4018544")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISPHudResultTopLiteTeamItem;

	[Token(Token = "0x4018545")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TeamName;

	[Token(Token = "0x4018546")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Rank;

	[Token(Token = "0x4018547")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BG;

	[Token(Token = "0x4018548")]
	[FieldOffset(Offset = "0x24")]
	public UITable Table;

	[Token(Token = "0x4018549")]
	[FieldOffset(Offset = "0x28")]
	public UITable LeagueTable;

	[Token(Token = "0x6017122")]
	[Address(RVA = "0x1D2DA74", Offset = "0x1D2DA74", VA = "0x1D2DA74")]
	public UISPHudResultTopLiteTeamItemView()
	{
	}

	[Token(Token = "0x6017123")]
	[Address(RVA = "0x1D2DA7C", Offset = "0x1D2DA7C", VA = "0x1D2DA7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017124")]
	[Address(RVA = "0x1D2DD24", Offset = "0x1D2DD24", VA = "0x1D2DD24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
