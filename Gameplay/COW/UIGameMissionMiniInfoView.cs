using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A1")]
public class UIGameMissionMiniInfoView : UIBaseView
{
	[Token(Token = "0x4015649")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x401564A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Countdown;

	[Token(Token = "0x401564B")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x6016493")]
	[Address(RVA = "0x2460BDC", Offset = "0x2460BDC", VA = "0x2460BDC")]
	public UIGameMissionMiniInfoView()
	{
	}

	[Token(Token = "0x6016494")]
	[Address(RVA = "0x2460BE4", Offset = "0x2460BE4", VA = "0x2460BE4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016495")]
	[Address(RVA = "0x2460E4C", Offset = "0x2460E4C", VA = "0x2460E4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
