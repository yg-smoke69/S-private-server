using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200370B")]
public class UIHudReportReplayItemView : UIBaseView
{
	[Token(Token = "0x40163AD")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTeam;

	[Token(Token = "0x40163AE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelName;

	[Token(Token = "0x40163AF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelTime;

	[Token(Token = "0x40163B0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BgSelected;

	[Token(Token = "0x40163B1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Bg;

	[Token(Token = "0x40163B2")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnSelect;

	[Token(Token = "0x60168CC")]
	[Address(RVA = "0x13ECA60", Offset = "0x13ECA60", VA = "0x13ECA60")]
	public UIHudReportReplayItemView()
	{
	}

	[Token(Token = "0x60168CD")]
	[Address(RVA = "0x13ECA68", Offset = "0x13ECA68", VA = "0x13ECA68", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168CE")]
	[Address(RVA = "0x13ECDD8", Offset = "0x13ECDD8", VA = "0x13ECDD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
