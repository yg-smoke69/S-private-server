using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200365A")]
public class UIHudFriendinviteView : UIBaseView
{
	[Token(Token = "0x4015D0C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton IgnoreToggle;

	[Token(Token = "0x4015D0D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject IgnoreCheck;

	[Token(Token = "0x4015D0E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel IgnoreDesc;

	[Token(Token = "0x4015D0F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel UserNameLabel;

	[Token(Token = "0x4015D10")]
	[FieldOffset(Offset = "0x24")]
	public UIButton AgreeBtn;

	[Token(Token = "0x4015D11")]
	[FieldOffset(Offset = "0x28")]
	public UIButton DisagreeBtn;

	[Token(Token = "0x4015D12")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel DisagreeTimeLabel;

	[Token(Token = "0x60166BB")]
	[Address(RVA = "0x1886BF4", Offset = "0x1886BF4", VA = "0x1886BF4")]
	public UIHudFriendinviteView()
	{
	}

	[Token(Token = "0x60166BC")]
	[Address(RVA = "0x1886BFC", Offset = "0x1886BFC", VA = "0x1886BFC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166BD")]
	[Address(RVA = "0x1886FD8", Offset = "0x1886FD8", VA = "0x1886FD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
