using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003483")]
public class UICommonSettingSliderItemView : UIBaseView
{
	[Token(Token = "0x401470B")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x401470C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LeftLabel;

	[Token(Token = "0x401470D")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton TipBtn;

	[Token(Token = "0x401470E")]
	[FieldOffset(Offset = "0x20")]
	public UISlider Slider;

	[Token(Token = "0x401470F")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Value;

	[Token(Token = "0x601613D")]
	[Address(RVA = "0x1EB8CF0", Offset = "0x1EB8CF0", VA = "0x1EB8CF0")]
	public UICommonSettingSliderItemView()
	{
	}

	[Token(Token = "0x601613E")]
	[Address(RVA = "0x1EB8CF8", Offset = "0x1EB8CF8", VA = "0x1EB8CF8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601613F")]
	[Address(RVA = "0x1EB9020", Offset = "0x1EB9020", VA = "0x1EB9020")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
