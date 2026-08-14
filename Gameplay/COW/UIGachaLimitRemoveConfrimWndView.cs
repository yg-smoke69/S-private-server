using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200358F")]
public class UIGachaLimitRemoveConfrimWndView : UIBaseView
{
	[Token(Token = "0x401550A")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid PreviewGrid;

	[Token(Token = "0x401550B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OKBtn;

	[Token(Token = "0x401550C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BtnLabel;

	[Token(Token = "0x601645D")]
	[Address(RVA = "0x2A16DD0", Offset = "0x2A16DD0", VA = "0x2A16DD0")]
	public UIGachaLimitRemoveConfrimWndView()
	{
	}

	[Token(Token = "0x601645E")]
	[Address(RVA = "0x2A16DD8", Offset = "0x2A16DD8", VA = "0x2A16DD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601645F")]
	[Address(RVA = "0x2A17040", Offset = "0x2A17040", VA = "0x2A17040")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
