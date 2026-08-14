using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003578")]
public class UIGachalegendaryContentView : UIBaseView
{
	[Token(Token = "0x4015357")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIGachalegendaryContent;

	[Token(Token = "0x4015358")]
	[FieldOffset(Offset = "0x18")]
	public Animator UIGachalegendaryAnim;

	[Token(Token = "0x4015359")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ItemDesc;

	[Token(Token = "0x401535A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ItemName;

	[Token(Token = "0x401535B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ItemDescLabel;

	[Token(Token = "0x401535C")]
	[FieldOffset(Offset = "0x28")]
	public UIButton stateBtn_3;

	[Token(Token = "0x401535D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Seleccted_3;

	[Token(Token = "0x401535E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LvupLabel;

	[Token(Token = "0x401535F")]
	[FieldOffset(Offset = "0x34")]
	public UICountDownLabel FreeCountdownLabel;

	[Token(Token = "0x4015360")]
	[FieldOffset(Offset = "0x38")]
	public UIButton TimeBg;

	[Token(Token = "0x4015361")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton PrivewBtn;

	[Token(Token = "0x4015362")]
	[FieldOffset(Offset = "0x40")]
	public UIButton progressBar;

	[Token(Token = "0x4015363")]
	[FieldOffset(Offset = "0x44")]
	public UIProgressBar LuckyProgressBar;

	[Token(Token = "0x4015364")]
	[FieldOffset(Offset = "0x48")]
	public GameObject CurrentFlag;

	[Token(Token = "0x4015365")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ProgressBarEffect;

	[Token(Token = "0x4015366")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ProgressEndEffect;

	[Token(Token = "0x4015367")]
	[FieldOffset(Offset = "0x54")]
	public GameObject CurrentLucky_Lable_Info;

	[Token(Token = "0x4015368")]
	[FieldOffset(Offset = "0x58")]
	public GameObject GetLuckyEffect;

	[Token(Token = "0x4015369")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject AllBuyBtn;

	[Token(Token = "0x401536A")]
	[FieldOffset(Offset = "0x60")]
	public UILabel PriceLabel;

	[Token(Token = "0x401536B")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BuffTipsBtn;

	[Token(Token = "0x401536C")]
	[FieldOffset(Offset = "0x68")]
	public UILabel BuffEffectLabel;

	[Token(Token = "0x401536D")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton BuyBuffBtn;

	[Token(Token = "0x401536E")]
	[FieldOffset(Offset = "0x70")]
	public GameObject BuyBuffDisable;

	[Token(Token = "0x401536F")]
	[FieldOffset(Offset = "0x74")]
	public GameObject BuyBuffEffect;

	[Token(Token = "0x4015370")]
	[FieldOffset(Offset = "0x78")]
	public GameObject BuyBuffEnable;

	[Token(Token = "0x4015371")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite TenBuyResultNum;

	[Token(Token = "0x4015372")]
	[FieldOffset(Offset = "0x80")]
	public Animator buffLabelEffect_1;

	[Token(Token = "0x4015373")]
	[FieldOffset(Offset = "0x84")]
	public Animator bufflabelEffect_2;

	[Token(Token = "0x4015374")]
	[FieldOffset(Offset = "0x88")]
	public UIWidget PreviewRightSide;

	[Token(Token = "0x4015375")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject GachaPreviewPosition;

	[Token(Token = "0x4015376")]
	[FieldOffset(Offset = "0x90")]
	public UIWidget PreviewLeftSide;

	[Token(Token = "0x4015377")]
	[FieldOffset(Offset = "0x94")]
	public GameObject PreviewLeftSideOpenPreviewPool;

	[Token(Token = "0x6016418")]
	[Address(RVA = "0x2EA90D0", Offset = "0x2EA90D0", VA = "0x2EA90D0")]
	public UIGachalegendaryContentView()
	{
	}

	[Token(Token = "0x6016419")]
	[Address(RVA = "0x2EA90D8", Offset = "0x2EA90D8", VA = "0x2EA90D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601641A")]
	[Address(RVA = "0x2EA9DE4", Offset = "0x2EA9DE4", VA = "0x2EA9DE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
