using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200390A")]
public class UIPointsRaceClanItemView : UIBaseView
{
	[Token(Token = "0x4017BA1")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Box;

	[Token(Token = "0x4017BA2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BoxIcon;

	[Token(Token = "0x4017BA3")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ClaimedObj;

	[Token(Token = "0x4017BA4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject UnlockObj;

	[Token(Token = "0x4017BA5")]
	[FieldOffset(Offset = "0x24")]
	public UILabel UnlockNumberText;

	[Token(Token = "0x4017BA6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PhaseArrow;

	[Token(Token = "0x4017BA7")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LockObj;

	[Token(Token = "0x4017BA8")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LockNumberText;

	[Token(Token = "0x6016EC7")]
	[Address(RVA = "0x2C5380C", Offset = "0x2C5380C", VA = "0x2C5380C")]
	public UIPointsRaceClanItemView()
	{
	}

	[Token(Token = "0x6016EC8")]
	[Address(RVA = "0x2C53814", Offset = "0x2C53814", VA = "0x2C53814", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EC9")]
	[Address(RVA = "0x2C53C2C", Offset = "0x2C53C2C", VA = "0x2C53C2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
