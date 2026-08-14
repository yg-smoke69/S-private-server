using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036E2")]
public class UIHUDPlayerGodBarView : UIBaseView
{
	[Token(Token = "0x40162AA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x40162AB")]
	[FieldOffset(Offset = "0x18")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x6016851")]
	[Address(RVA = "0x1686CC0", Offset = "0x1686CC0", VA = "0x1686CC0")]
	public UIHUDPlayerGodBarView()
	{
	}

	[Token(Token = "0x6016852")]
	[Address(RVA = "0x1686CC8", Offset = "0x1686CC8", VA = "0x1686CC8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016853")]
	[Address(RVA = "0x1686EC4", Offset = "0x1686EC4", VA = "0x1686EC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
