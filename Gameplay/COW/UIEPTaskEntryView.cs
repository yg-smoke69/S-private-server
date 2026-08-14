using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003521")]
public class UIEPTaskEntryView : UIBaseView
{
	[Token(Token = "0x4014F8E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Icon;

	[Token(Token = "0x4014F8F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ChallengeTips;

	[Token(Token = "0x4014F90")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4014F91")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NewTag;

	[Token(Token = "0x6016313")]
	[Address(RVA = "0x2BB00BC", Offset = "0x2BB00BC", VA = "0x2BB00BC")]
	public UIEPTaskEntryView()
	{
	}

	[Token(Token = "0x6016314")]
	[Address(RVA = "0x2BB00C4", Offset = "0x2BB00C4", VA = "0x2BB00C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016315")]
	[Address(RVA = "0x2BB0374", Offset = "0x2BB0374", VA = "0x2BB0374")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
