using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003794")]
public class UIHUDUGC_LeaderboardButtonView : UIBaseView
{
	[Token(Token = "0x401683B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Button;

	[Token(Token = "0x401683C")]
	[FieldOffset(Offset = "0x18")]
	public Transform Root;

	[Token(Token = "0x6016A67")]
	[Address(RVA = "0x2E0B45C", Offset = "0x2E0B45C", VA = "0x2E0B45C")]
	public UIHUDUGC_LeaderboardButtonView()
	{
	}

	[Token(Token = "0x6016A68")]
	[Address(RVA = "0x2E0B464", Offset = "0x2E0B464", VA = "0x2E0B464", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A69")]
	[Address(RVA = "0x2E0B644", Offset = "0x2E0B644", VA = "0x2E0B644")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
