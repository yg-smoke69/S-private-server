using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CA3")]
public class UIFrontEndPreviewBundlePreviewBaseView : UIFrontEndPreviewUIComponentBaseView
{
	[Token(Token = "0x40110A7")]
	[FieldOffset(Offset = "0xC")]
	public GameObject BundleTitleContainer;

	[Token(Token = "0x40110A8")]
	[FieldOffset(Offset = "0x10")]
	public UISprite BundleBg;

	[Token(Token = "0x40110A9")]
	[FieldOffset(Offset = "0x14")]
	public UILabel PreviewTitleLabel;

	[Token(Token = "0x40110AA")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40110AB")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList PreviewEasyList;

	[Token(Token = "0x6012A91")]
	[Address(RVA = "0x27E1748", Offset = "0x27E1748", VA = "0x27E1748")]
	public UIFrontEndPreviewBundlePreviewBaseView()
	{
	}
}
