using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039AD")]
public class UISettingPopBoxView : UIBaseView
{
	[Token(Token = "0x401835C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCancel;

	[Token(Token = "0x401835D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnOk;

	[Token(Token = "0x401835E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Desc_Label;

	[Token(Token = "0x60170AE")]
	[Address(RVA = "0x1A5B890", Offset = "0x1A5B890", VA = "0x1A5B890")]
	public UISettingPopBoxView()
	{
	}

	[Token(Token = "0x60170AF")]
	[Address(RVA = "0x1A5B898", Offset = "0x1A5B898", VA = "0x1A5B898", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170B0")]
	[Address(RVA = "0x1A5BB00", Offset = "0x1A5BB00", VA = "0x1A5BB00")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
