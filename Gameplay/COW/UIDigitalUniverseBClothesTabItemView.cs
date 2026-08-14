using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034C9")]
public class UIDigitalUniverseBClothesTabItemView : UIBaseView
{
	[Token(Token = "0x4014AAD")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ClothCon;

	[Token(Token = "0x4014AAE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RewardCon;

	[Token(Token = "0x4014AAF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject OwnedInfo;

	[Token(Token = "0x4014AB0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NormalRewardCon;

	[Token(Token = "0x4014AB1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BigRewardCon;

	[Token(Token = "0x4014AB2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject VfxUnlock;

	[Token(Token = "0x4014AB3")]
	[FieldOffset(Offset = "0x2C")]
	public Animator UIDigitalUniverseBClothesTabItem;

	[Token(Token = "0x601620F")]
	[Address(RVA = "0x2D8567C", Offset = "0x2D8567C", VA = "0x2D8567C")]
	public UIDigitalUniverseBClothesTabItemView()
	{
	}

	[Token(Token = "0x6016210")]
	[Address(RVA = "0x2D85684", Offset = "0x2D85684", VA = "0x2D85684", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016211")]
	[Address(RVA = "0x2D85A24", Offset = "0x2D85A24", VA = "0x2D85A24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
