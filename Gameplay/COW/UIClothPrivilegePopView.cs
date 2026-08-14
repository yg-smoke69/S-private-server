using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200346E")]
public class UIClothPrivilegePopView : UIBaseView
{
	[Token(Token = "0x4014637")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIClothPrivilegePop;

	[Token(Token = "0x4014638")]
	[FieldOffset(Offset = "0x18")]
	public UITable containerTable;

	[Token(Token = "0x4014639")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject container;

	[Token(Token = "0x401463A")]
	[FieldOffset(Offset = "0x20")]
	public UIButton MaskClose;

	[Token(Token = "0x401463B")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteDragBg;

	[Token(Token = "0x60160FE")]
	[Address(RVA = "0x2CD3228", Offset = "0x2CD3228", VA = "0x2CD3228")]
	public UIClothPrivilegePopView()
	{
	}

	[Token(Token = "0x60160FF")]
	[Address(RVA = "0x2CD3230", Offset = "0x2CD3230", VA = "0x2CD3230", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016100")]
	[Address(RVA = "0x2CD3540", Offset = "0x2CD3540", VA = "0x2CD3540")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
