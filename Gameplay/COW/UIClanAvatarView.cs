using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003444")]
public class UIClanAvatarView : UIBaseView
{
	[Token(Token = "0x40143F5")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Mask;

	[Token(Token = "0x40143F6")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016080")]
	[Address(RVA = "0x2F22BDC", Offset = "0x2F22BDC", VA = "0x2F22BDC")]
	public UIClanAvatarView()
	{
	}

	[Token(Token = "0x6016081")]
	[Address(RVA = "0x2F22BE4", Offset = "0x2F22BE4", VA = "0x2F22BE4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016082")]
	[Address(RVA = "0x2F22DEC", Offset = "0x2F22DEC", VA = "0x2F22DEC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
