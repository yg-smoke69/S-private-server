using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035CB")]
public class UIHudAOHLevelUpHintView : UIBaseView
{
	[Token(Token = "0x401589D")]
	[FieldOffset(Offset = "0x14")]
	public UISprite HeadLevelIcon;

	[Token(Token = "0x401589E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ScoreLabel;

	[Token(Token = "0x601650F")]
	[Address(RVA = "0x163BFC8", Offset = "0x163BFC8", VA = "0x163BFC8")]
	public UIHudAOHLevelUpHintView()
	{
	}

	[Token(Token = "0x6016510")]
	[Address(RVA = "0x163BFD0", Offset = "0x163BFD0", VA = "0x163BFD0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016511")]
	[Address(RVA = "0x163C1D8", Offset = "0x163C1D8", VA = "0x163C1D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
