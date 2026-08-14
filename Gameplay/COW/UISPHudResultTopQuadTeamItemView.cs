using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D5")]
public class UISPHudResultTopQuadTeamItemView : UIBaseView
{
	[Token(Token = "0x401854A")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISPHudResultTopQuadTeamItem;

	[Token(Token = "0x401854B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TeamName;

	[Token(Token = "0x401854C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x401854D")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Rank;

	[Token(Token = "0x401854E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject IconBG;

	[Token(Token = "0x401854F")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Icon;

	[Token(Token = "0x4018550")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite FakeIcon;

	[Token(Token = "0x4018551")]
	[FieldOffset(Offset = "0x30")]
	public UITable Table;

	[Token(Token = "0x4018552")]
	[FieldOffset(Offset = "0x34")]
	public UITable LeagueTable;

	[Token(Token = "0x6017125")]
	[Address(RVA = "0x1D2DD2C", Offset = "0x1D2DD2C", VA = "0x1D2DD2C")]
	public UISPHudResultTopQuadTeamItemView()
	{
	}

	[Token(Token = "0x6017126")]
	[Address(RVA = "0x1D2DD34", Offset = "0x1D2DD34", VA = "0x1D2DD34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017127")]
	[Address(RVA = "0x1D2E0B8", Offset = "0x1D2E0B8", VA = "0x1D2E0B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
