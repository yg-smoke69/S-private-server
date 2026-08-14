using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200341B")]
public class UIChampionshipTeamApplyItemView : UIBaseView
{
	[Token(Token = "0x40141ED")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Item;

	[Token(Token = "0x40141EE")]
	[FieldOffset(Offset = "0x18")]
	public UISprite bg;

	[Token(Token = "0x40141EF")]
	[FieldOffset(Offset = "0x1C")]
	public Transform BaseProfile;

	[Token(Token = "0x40141F0")]
	[FieldOffset(Offset = "0x20")]
	public UIButton View;

	[Token(Token = "0x40141F1")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Reject;

	[Token(Token = "0x40141F2")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Acept;

	[Token(Token = "0x6016005")]
	[Address(RVA = "0x283BABC", Offset = "0x283BABC", VA = "0x283BABC")]
	public UIChampionshipTeamApplyItemView()
	{
	}

	[Token(Token = "0x6016006")]
	[Address(RVA = "0x283BAC4", Offset = "0x283BAC4", VA = "0x283BAC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016007")]
	[Address(RVA = "0x283BE24", Offset = "0x283BE24", VA = "0x283BE24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
