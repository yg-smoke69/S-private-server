using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037D5")]
public class UIHUDWereWolvesPrepareInfoView : UIBaseView
{
	[Token(Token = "0x4016A51")]
	[FieldOffset(Offset = "0x14")]
	public GameObject VoiceForbiddenLabel;

	[Token(Token = "0x4016A52")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LeftTimeLabel;

	[Token(Token = "0x6016B2A")]
	[Address(RVA = "0x1626970", Offset = "0x1626970", VA = "0x1626970")]
	public UIHUDWereWolvesPrepareInfoView()
	{
	}

	[Token(Token = "0x6016B2B")]
	[Address(RVA = "0x1626978", Offset = "0x1626978", VA = "0x1626978", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B2C")]
	[Address(RVA = "0x1626B74", Offset = "0x1626B74", VA = "0x1626B74")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
