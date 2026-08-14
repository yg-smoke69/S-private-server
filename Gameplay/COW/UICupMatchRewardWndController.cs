using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200207D")]
public class UICupMatchRewardWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400CBB4")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchRewardWndView m_View;

	[Token(Token = "0x400CBB5")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBB6")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CupMatchType;

	[Token(Token = "0x400CBB7")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CupMatchID;

	[Token(Token = "0x400CBB8")]
	[FieldOffset(Offset = "0x58")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CBB9")]
	[FieldOffset(Offset = "0x5C")]
	private UICupMatchRewardBoxAnimController m_BoxCtrl;

	[Token(Token = "0x600A6D5")]
	[Address(RVA = "0x2AB44D4", Offset = "0x2AB44D4", VA = "0x2AB44D4")]
	public UICupMatchRewardWndController()
	{
	}

	[Token(Token = "0x600A6D6")]
	[Address(RVA = "0x2AB44DC", Offset = "0x2AB44DC", VA = "0x2AB44DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A6D7")]
	[Address(RVA = "0x2AB4584", Offset = "0x2AB4584", VA = "0x2AB4584", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A6D8")]
	[Address(RVA = "0x2AB4B70", Offset = "0x2AB4B70", VA = "0x2AB4B70", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A6D9")]
	[Address(RVA = "0x2AB4BF8", Offset = "0x2AB4BF8", VA = "0x2AB4BF8")]
	public void SetData(uint cupMatchType, uint cupMatchID)
	{
	}

	[Token(Token = "0x600A6DA")]
	[Address(RVA = "0x2AB4D60", Offset = "0x2AB4D60", VA = "0x2AB4D60")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A6DB")]
	[Address(RVA = "0x2AB48D8", Offset = "0x2AB48D8", VA = "0x2AB48D8")]
	private void HideAllUI()
	{
	}

	[Token(Token = "0x600A6DC")]
	[Address(RVA = "0x2AB5130", Offset = "0x2AB5130", VA = "0x2AB5130")]
	private void OnClaimBtnClick()
	{
	}

	[Token(Token = "0x600A6DD")]
	[Address(RVA = "0x2AB51B8", Offset = "0x2AB51B8", VA = "0x2AB51B8")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x600A6DE")]
	[Address(RVA = "0x2AB521C", Offset = "0x2AB521C", VA = "0x2AB521C")]
	private void OnGotoBtnClick()
	{
	}

	[Token(Token = "0x600A6DF")]
	[Address(RVA = "0x2AB5350", Offset = "0x2AB5350", VA = "0x2AB5350", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A6E0")]
	[Address(RVA = "0x2AB53A8", Offset = "0x2AB53A8", VA = "0x2AB53A8", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600A6E1")]
	[Address(RVA = "0x2AB5400", Offset = "0x2AB5400", VA = "0x2AB5400", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A6E2")]
	[Address(RVA = "0x2AB56F4", Offset = "0x2AB56F4", VA = "0x2AB56F4", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A6E3")]
	[Address(RVA = "0x2AB5788", Offset = "0x2AB5788", VA = "0x2AB5788")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A6E4")]
	[Address(RVA = "0x2AB5790", Offset = "0x2AB5790", VA = "0x2AB5790")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A6E5")]
	[Address(RVA = "0x2AB5798", Offset = "0x2AB5798", VA = "0x2AB5798")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A6E6")]
	[Address(RVA = "0x2AB57A0", Offset = "0x2AB57A0", VA = "0x2AB57A0")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}
}
