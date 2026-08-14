using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003510")]
public class UIElitePassUnlockEPPopupView : UIBaseView
{
	[Token(Token = "0x4014EEA")]
	[FieldOffset(Offset = "0x14")]
	public UILabel title;

	[Token(Token = "0x4014EEB")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BtnLabel;

	[Token(Token = "0x4014EEC")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CloseBtn;

	[Token(Token = "0x4014EED")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EPPrivilegeBundle;

	[Token(Token = "0x4014EEE")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EPPrivilege;

	[Token(Token = "0x60162E0")]
	[Address(RVA = "0x3069BD8", Offset = "0x3069BD8", VA = "0x3069BD8")]
	public UIElitePassUnlockEPPopupView()
	{
	}

	[Token(Token = "0x60162E1")]
	[Address(RVA = "0x3069BE0", Offset = "0x3069BE0", VA = "0x3069BE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162E2")]
	[Address(RVA = "0x3069EF0", Offset = "0x3069EF0", VA = "0x3069EF0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
