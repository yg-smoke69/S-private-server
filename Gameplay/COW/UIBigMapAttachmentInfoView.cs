using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003400")]
public class UIBigMapAttachmentInfoView : UIBaseView
{
	[Token(Token = "0x401405E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite attachIcon;

	[Token(Token = "0x401405F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel attachLabel;

	[Token(Token = "0x6015FB4")]
	[Address(RVA = "0x10C32D8", Offset = "0x10C32D8", VA = "0x10C32D8")]
	public UIBigMapAttachmentInfoView()
	{
	}

	[Token(Token = "0x6015FB5")]
	[Address(RVA = "0x10C32E0", Offset = "0x10C32E0", VA = "0x10C32E0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FB6")]
	[Address(RVA = "0x10C34E8", Offset = "0x10C34E8", VA = "0x10C34E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
