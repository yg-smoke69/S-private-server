using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200371A")]
public class UIHudRushingPetsJumpView : UIBaseView
{
	[Token(Token = "0x4016437")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnJump;

	[Token(Token = "0x4016438")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BtnSprite;

	[Token(Token = "0x60168F9")]
	[Address(RVA = "0x1C46AEC", Offset = "0x1C46AEC", VA = "0x1C46AEC")]
	public UIHudRushingPetsJumpView()
	{
	}

	[Token(Token = "0x60168FA")]
	[Address(RVA = "0x1C46AF4", Offset = "0x1C46AF4", VA = "0x1C46AF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168FB")]
	[Address(RVA = "0x1C46CFC", Offset = "0x1C46CFC", VA = "0x1C46CFC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
