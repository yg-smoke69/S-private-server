using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003643")]
public class UIHudEnergyStoneMarkView : UIBaseView
{
	[Token(Token = "0x4015C45")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ArrowUp;

	[Token(Token = "0x4015C46")]
	[FieldOffset(Offset = "0x18")]
	public UISprite arrowRight;

	[Token(Token = "0x4015C47")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite arrowDown;

	[Token(Token = "0x4015C48")]
	[FieldOffset(Offset = "0x20")]
	public UISprite arrowLeft;

	[Token(Token = "0x4015C49")]
	[FieldOffset(Offset = "0x24")]
	public GameObject MyTeam;

	[Token(Token = "0x4015C4A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject OppoTeam;

	[Token(Token = "0x4015C4B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Distance;

	[Token(Token = "0x4015C4C")]
	[FieldOffset(Offset = "0x30")]
	public EnergyStoneMarkScore ScoreTemplete;

	[Token(Token = "0x4015C4D")]
	[FieldOffset(Offset = "0x34")]
	public Transform ScorePosition;

	[Token(Token = "0x6016676")]
	[Address(RVA = "0x1CE5860", Offset = "0x1CE5860", VA = "0x1CE5860")]
	public UIHudEnergyStoneMarkView()
	{
	}

	[Token(Token = "0x6016677")]
	[Address(RVA = "0x1CE5868", Offset = "0x1CE5868", VA = "0x1CE5868", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016678")]
	[Address(RVA = "0x1CE5CD0", Offset = "0x1CE5CD0", VA = "0x1CE5CD0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
