using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200381F")]
public class UILegendClothVaultPickView : UIBaseView
{
	[Token(Token = "0x4016DA9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ClothPickContainer;

	[Token(Token = "0x4016DAA")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollViewCloth;

	[Token(Token = "0x4016DAB")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid GridCenter;

	[Token(Token = "0x4016DAC")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid GridLeft;

	[Token(Token = "0x6016C08")]
	[Address(RVA = "0x2541448", Offset = "0x2541448", VA = "0x2541448")]
	public UILegendClothVaultPickView()
	{
	}

	[Token(Token = "0x6016C09")]
	[Address(RVA = "0x2541450", Offset = "0x2541450", VA = "0x2541450", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C0A")]
	[Address(RVA = "0x254170C", Offset = "0x254170C", VA = "0x254170C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
