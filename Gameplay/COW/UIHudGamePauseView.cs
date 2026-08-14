using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200365F")]
public class UIHudGamePauseView : UIBaseView
{
	[Token(Token = "0x4015D1C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PauseIcon;

	[Token(Token = "0x4015D1D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CountDownTxt;

	[Token(Token = "0x4015D1E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel InfoTxt;

	[Token(Token = "0x4015D1F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel InfoTxt_UGC;

	[Token(Token = "0x4015D20")]
	[FieldOffset(Offset = "0x24")]
	public GameObject UGCPause;

	[Token(Token = "0x4015D21")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NormalPause;

	[Token(Token = "0x60166CA")]
	[Address(RVA = "0x188B738", Offset = "0x188B738", VA = "0x188B738")]
	public UIHudGamePauseView()
	{
	}

	[Token(Token = "0x60166CB")]
	[Address(RVA = "0x188B740", Offset = "0x188B740", VA = "0x188B740", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166CC")]
	[Address(RVA = "0x188BAA4", Offset = "0x188BAA4", VA = "0x188BAA4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
