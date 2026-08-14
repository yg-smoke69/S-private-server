using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EB0")]
public class UIDigitaluniverseBClothesDoorTabItemController : UIDigitaluniverseBTabBaseController
{
	[Token(Token = "0x400C118")]
	[FieldOffset(Offset = "0x40")]
	private UIDigitalUniverseBClothesTabItemView m_ClothesTabView;

	[Token(Token = "0x60094A4")]
	[Address(RVA = "0x2ACD054", Offset = "0x2ACD054", VA = "0x2ACD054")]
	public UIDigitaluniverseBClothesDoorTabItemController()
	{
	}

	[Token(Token = "0x60094A5")]
	[Address(RVA = "0x2ACD05C", Offset = "0x2ACD05C", VA = "0x2ACD05C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60094A6")]
	[Address(RVA = "0x2ACD104", Offset = "0x2ACD104", VA = "0x2ACD104", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60094A7")]
	[Address(RVA = "0x2AC84CC", Offset = "0x2AC84CC", VA = "0x2AC84CC")]
	public Transform GetMormalAwardPos()
	{
		return null;
	}

	[Token(Token = "0x60094A8")]
	[Address(RVA = "0x2ACD218", Offset = "0x2ACD218", VA = "0x2ACD218")]
	public Transform GetBigAwardPos()
	{
		return null;
	}

	[Token(Token = "0x60094A9")]
	[Address(RVA = "0x2AC8558", Offset = "0x2AC8558", VA = "0x2AC8558")]
	public UIDigitaluniverseBClothesAwardItemController GetBigAwardController()
	{
		return null;
	}

	[Token(Token = "0x60094AA")]
	[Address(RVA = "0x2AC83B0", Offset = "0x2AC83B0", VA = "0x2AC83B0")]
	public void ShowNormalAward(bool flag)
	{
	}

	[Token(Token = "0x60094AB")]
	[Address(RVA = "0x2AC9284", Offset = "0x2AC9284", VA = "0x2AC9284")]
	public void NeedShowOwned(bool flag)
	{
	}

	[Token(Token = "0x60094AC")]
	[Address(RVA = "0x2ACCC9C", Offset = "0x2ACCC9C", VA = "0x2ACCC9C")]
	public void ShowUnlockVFX()
	{
	}

	[Token(Token = "0x60094AD")]
	[Address(RVA = "0x2ACCFC4", Offset = "0x2ACCFC4", VA = "0x2ACCFC4")]
	public void OpenTabInPlay()
	{
	}

	[Token(Token = "0x60094AE")]
	[Address(RVA = "0x2ACD2A4", Offset = "0x2ACD2A4", VA = "0x2ACD2A4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
