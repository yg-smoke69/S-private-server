using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035BD")]
public class UIHDLobbyYardView : UIBaseView
{
	[Token(Token = "0x401581F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject NaviPage;

	[Token(Token = "0x4015820")]
	[FieldOffset(Offset = "0x18")]
	public UIButton HelpBtn;

	[Token(Token = "0x4015821")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton leaveBtn;

	[Token(Token = "0x4015822")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ShareButton;

	[Token(Token = "0x4015823")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Mask;

	[Token(Token = "0x60164E5")]
	[Address(RVA = "0x20344FC", Offset = "0x20344FC", VA = "0x20344FC")]
	public UIHDLobbyYardView()
	{
	}

	[Token(Token = "0x60164E6")]
	[Address(RVA = "0x2034504", Offset = "0x2034504", VA = "0x2034504", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164E7")]
	[Address(RVA = "0x2034820", Offset = "0x2034820", VA = "0x2034820")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
