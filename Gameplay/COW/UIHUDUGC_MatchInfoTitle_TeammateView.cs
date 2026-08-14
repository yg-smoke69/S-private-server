using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003797")]
public class UIHUDUGC_MatchInfoTitle_TeammateView : UIBaseView
{
	[Token(Token = "0x4016847")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Alive;

	[Token(Token = "0x4016848")]
	[FieldOffset(Offset = "0x18")]
	public UISprite KnockDown;

	[Token(Token = "0x4016849")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Dead;

	[Token(Token = "0x401684A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Flag;

	[Token(Token = "0x6016A70")]
	[Address(RVA = "0x2E14668", Offset = "0x2E14668", VA = "0x2E14668")]
	public UIHUDUGC_MatchInfoTitle_TeammateView()
	{
	}

	[Token(Token = "0x6016A71")]
	[Address(RVA = "0x2E14670", Offset = "0x2E14670", VA = "0x2E14670", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A72")]
	[Address(RVA = "0x2E14920", Offset = "0x2E14920", VA = "0x2E14920")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
