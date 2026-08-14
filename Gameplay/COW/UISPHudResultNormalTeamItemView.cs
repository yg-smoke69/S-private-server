using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D0")]
public class UISPHudResultNormalTeamItemView : UIBaseView
{
	[Token(Token = "0x4018534")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISPHudResultNormalTeamItem;

	[Token(Token = "0x4018535")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Id;

	[Token(Token = "0x4018536")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x6017116")]
	[Address(RVA = "0x1D2B644", Offset = "0x1D2B644", VA = "0x1D2B644")]
	public UISPHudResultNormalTeamItemView()
	{
	}

	[Token(Token = "0x6017117")]
	[Address(RVA = "0x1D2B64C", Offset = "0x1D2B64C", VA = "0x1D2B64C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017118")]
	[Address(RVA = "0x1D2B8B4", Offset = "0x1D2B8B4", VA = "0x1D2B8B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
