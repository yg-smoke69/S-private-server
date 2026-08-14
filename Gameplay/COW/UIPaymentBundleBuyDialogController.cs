using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A12")]
public class UIPaymentBundleBuyDialogController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x40102C3")]
	[FieldOffset(Offset = "0x48")]
	private UIPaymentBundleBuyDialogView m_View;

	[Token(Token = "0x40102C4")]
	[FieldOffset(Offset = "0x4C")]
	private PayBundleWindowDesc m_Data;

	[Token(Token = "0x601102F")]
	[Address(RVA = "0x2868A64", Offset = "0x2868A64", VA = "0x2868A64")]
	public UIPaymentBundleBuyDialogController()
	{
	}

	[Token(Token = "0x6011030")]
	[Address(RVA = "0x2868A6C", Offset = "0x2868A6C", VA = "0x2868A6C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011031")]
	[Address(RVA = "0x2868B14", Offset = "0x2868B14", VA = "0x2868B14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011032")]
	[Address(RVA = "0x2868D94", Offset = "0x2868D94", VA = "0x2868D94", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011033")]
	[Address(RVA = "0x2868F58", Offset = "0x2868F58", VA = "0x2868F58")]
	public void SetViewData(uint bundleId, string title)
	{
	}

	[Token(Token = "0x6011034")]
	[Address(RVA = "0x28695C4", Offset = "0x28695C4", VA = "0x28695C4")]
	private void OnPaidFailed(object[] data)
	{
	}

	[Token(Token = "0x6011035")]
	[Address(RVA = "0x28696F4", Offset = "0x28696F4", VA = "0x28696F4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011036")]
	[Address(RVA = "0x2869858", Offset = "0x2869858", VA = "0x2869858", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011037")]
	[Address(RVA = "0x28698BC", Offset = "0x28698BC", VA = "0x28698BC")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x6011038")]
	[Address(RVA = "0x2869E0C", Offset = "0x2869E0C", VA = "0x2869E0C")]
	private void _003COnBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x6011039")]
	[Address(RVA = "0x2869EB4", Offset = "0x2869EB4", VA = "0x2869EB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601103A")]
	[Address(RVA = "0x2869EBC", Offset = "0x2869EBC", VA = "0x2869EBC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
