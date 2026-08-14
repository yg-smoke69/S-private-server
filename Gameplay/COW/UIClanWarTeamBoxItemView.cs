using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200346A")]
public class UIClanWarTeamBoxItemView : UIBaseView
{
	[Token(Token = "0x40145F8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ProgressNum;

	[Token(Token = "0x40145F9")]
	[FieldOffset(Offset = "0x18")]
	public UIButton TeamBoxBtn;

	[Token(Token = "0x40145FA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TeamBoxUnavailable;

	[Token(Token = "0x40145FB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject TeamBoxAvailable;

	[Token(Token = "0x40145FC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TeamBoxAvailableTips;

	[Token(Token = "0x40145FD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TeamBoxClaimed;

	[Token(Token = "0x60160F2")]
	[Address(RVA = "0x290D3F4", Offset = "0x290D3F4", VA = "0x290D3F4")]
	public UIClanWarTeamBoxItemView()
	{
	}

	[Token(Token = "0x60160F3")]
	[Address(RVA = "0x290D3FC", Offset = "0x290D3FC", VA = "0x290D3FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160F4")]
	[Address(RVA = "0x290D754", Offset = "0x290D754", VA = "0x290D754")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
