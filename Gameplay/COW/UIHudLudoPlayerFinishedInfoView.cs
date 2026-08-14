using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200369D")]
public class UIHudLudoPlayerFinishedInfoView : UIBaseView
{
	[Token(Token = "0x4015F97")]
	[FieldOffset(Offset = "0x14")]
	public UILabel localPlayerFinishedCnt;

	[Token(Token = "0x4015F98")]
	[FieldOffset(Offset = "0x18")]
	public UILabel allFinishedInfo;

	[Token(Token = "0x6016784")]
	[Address(RVA = "0xFF77B8", Offset = "0xFF77B8", VA = "0xFF77B8")]
	public UIHudLudoPlayerFinishedInfoView()
	{
	}

	[Token(Token = "0x6016785")]
	[Address(RVA = "0xFF77C0", Offset = "0xFF77C0", VA = "0xFF77C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016786")]
	[Address(RVA = "0xFF79C8", Offset = "0xFF79C8", VA = "0xFF79C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
