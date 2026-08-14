using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003958")]
public class UIRewardedVideoPopupWindowView : UIBaseView
{
	[Token(Token = "0x401801D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel DescLabel;

	[Token(Token = "0x401801E")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnLoadAndPlay;

	[Token(Token = "0x401801F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BtnText;

	[Token(Token = "0x6016FAF")]
	[Address(RVA = "0x1E5AD48", Offset = "0x1E5AD48", VA = "0x1E5AD48")]
	public UIRewardedVideoPopupWindowView()
	{
	}

	[Token(Token = "0x6016FB0")]
	[Address(RVA = "0x1E5AD50", Offset = "0x1E5AD50", VA = "0x1E5AD50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FB1")]
	[Address(RVA = "0x1E5AFB8", Offset = "0x1E5AFB8", VA = "0x1E5AFB8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
