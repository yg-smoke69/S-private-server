using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003813")]
public class UILadderMatchSelectGameModePopupView : UIBaseView
{
	[Token(Token = "0x4016CFA")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnMask;

	[Token(Token = "0x4016CFB")]
	[FieldOffset(Offset = "0x18")]
	public UITable TableGameMode;

	[Token(Token = "0x4016CFC")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid GridGameMode;

	[Token(Token = "0x4016CFD")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClose;

	[Token(Token = "0x6016BE4")]
	[Address(RVA = "0x22D8A74", Offset = "0x22D8A74", VA = "0x22D8A74")]
	public UILadderMatchSelectGameModePopupView()
	{
	}

	[Token(Token = "0x6016BE5")]
	[Address(RVA = "0x22D8A7C", Offset = "0x22D8A7C", VA = "0x22D8A7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BE6")]
	[Address(RVA = "0x22D8D44", Offset = "0x22D8D44", VA = "0x22D8D44")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
