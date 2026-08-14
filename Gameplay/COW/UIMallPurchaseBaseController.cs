using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20021F2")]
public class UIMallPurchaseBaseController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400D48E")]
	[FieldOffset(Offset = "0x48")]
	protected CSSharedItemData m_ItemData;

	[Token(Token = "0x400D48F")]
	[FieldOffset(Offset = "0x4C")]
	protected int m_Count;

	[Token(Token = "0x400D490")]
	[FieldOffset(Offset = "0x50")]
	protected int m_MaxCount;

	[Token(Token = "0x400D491")]
	[FieldOffset(Offset = "0x54")]
	protected VoucherData m_VoucherData;

	[Token(Token = "0x400D492")]
	[FieldOffset(Offset = "0x58")]
	protected UIVoucherController m_VoucherCtrl;

	[Token(Token = "0x400D493")]
	[FieldOffset(Offset = "0x5C")]
	protected UIModelMall m_ModelMall;

	[Token(Token = "0x400D494")]
	[FieldOffset(Offset = "0x60")]
	protected UIMallPurchaseViewExt m_View;

	[Token(Token = "0x400D495")]
	[FieldOffset(Offset = "0x64")]
	protected uint m_CoinsPrice;

	[Token(Token = "0x400D496")]
	[FieldOffset(Offset = "0x68")]
	protected uint m_GemsPrice;

	[Token(Token = "0x400D497")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_ShowVoucher;

	[Token(Token = "0x400D498")]
	[FieldOffset(Offset = "0x6D")]
	protected bool m_InputExceedNotify;

	[Token(Token = "0x400D499")]
	[FieldOffset(Offset = "0x6E")]
	private bool m_CanShowModifyContainer;

	[Token(Token = "0x17001036")]
	protected virtual int ItemCount
	{
		[Token(Token = "0x600B6BE")]
		[Address(RVA = "0x2264544", Offset = "0x2264544", VA = "0x2264544", Slot = "49")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B6BF")]
		[Address(RVA = "0x22645A0", Offset = "0x22645A0", VA = "0x22645A0", Slot = "50")]
		set
		{
		}
	}

	[Token(Token = "0x600B6BD")]
	[Address(RVA = "0x2251640", Offset = "0x2251640", VA = "0x2251640")]
	public UIMallPurchaseBaseController()
	{
	}

	[Token(Token = "0x600B6C0")]
	[Address(RVA = "0x2264BCC", Offset = "0x2264BCC", VA = "0x2264BCC")]
	public int GetItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x600B6C1")]
	[Address(RVA = "0x22647AC", Offset = "0x22647AC", VA = "0x22647AC")]
	protected void SetPriceLabelText()
	{
	}

	[Token(Token = "0x600B6C2")]
	[Address(RVA = "0x2264A90", Offset = "0x2264A90", VA = "0x2264A90")]
	protected void RefreshVoucherCtrlTotalPrice()
	{
	}

	[Token(Token = "0x600B6C3")]
	[Address(RVA = "0x225225C", Offset = "0x225225C", VA = "0x225225C")]
	protected uint GetVoucherID()
	{
		return default(uint);
	}

	[Token(Token = "0x600B6C4")]
	[Address(RVA = "0x2264C24", Offset = "0x2264C24", VA = "0x2264C24")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B6C5")]
	[Address(RVA = "0x225198C", Offset = "0x225198C", VA = "0x225198C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B6C6")]
	[Address(RVA = "0x2264CC8", Offset = "0x2264CC8", VA = "0x2264CC8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B6C7")]
	[Address(RVA = "0x2264D2C", Offset = "0x2264D2C", VA = "0x2264D2C")]
	protected void OnPlusBtnClick()
	{
	}

	[Token(Token = "0x600B6C8")]
	[Address(RVA = "0x2265830", Offset = "0x2265830", VA = "0x2265830")]
	protected void OnMinsBtnClick()
	{
	}

	[Token(Token = "0x600B6C9")]
	[Address(RVA = "0x22658D8", Offset = "0x22658D8", VA = "0x22658D8")]
	protected void OnMaxBtnClick()
	{
	}

	[Token(Token = "0x600B6CA")]
	[Address(RVA = "0x2265948", Offset = "0x2265948", VA = "0x2265948")]
	private void OnAddTenBtnClick()
	{
	}

	[Token(Token = "0x600B6CB")]
	[Address(RVA = "0x225337C", Offset = "0x225337C", VA = "0x225337C")]
	protected void RefreshModifyBtn(uint limited_purchase_times, bool forceMax = false)
	{
	}

	[Token(Token = "0x600B6CC")]
	[Address(RVA = "0x22643D4", Offset = "0x22643D4", VA = "0x22643D4")]
	protected void SetMaxCount(int maxCount)
	{
	}

	[Token(Token = "0x600B6CD")]
	[Address(RVA = "0x2252660", Offset = "0x2252660", VA = "0x2252660")]
	protected void SetMaxPurchaseCount(uint limited_purchase_times, uint purchase_times)
	{
	}

	[Token(Token = "0x600B6CE")]
	[Address(RVA = "0x22527AC", Offset = "0x22527AC", VA = "0x22527AC")]
	protected void ShowLimitedPurchase(uint limited_purchase_times, uint purchase_times)
	{
	}

	[Token(Token = "0x600B6CF")]
	[Address(RVA = "0x2252F94", Offset = "0x2252F94", VA = "0x2252F94")]
	protected void ShowModifyCountContainer()
	{
	}

	[Token(Token = "0x600B6D0")]
	[Address(RVA = "0x2252CCC", Offset = "0x2252CCC", VA = "0x2252CCC")]
	protected void ShowVoucherContainer()
	{
	}

	[Token(Token = "0x600B6D1")]
	[Address(RVA = "0x2265B8C", Offset = "0x2265B8C", VA = "0x2265B8C", Slot = "46")]
	public UIVoucherController OpenVoucherController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B6D2")]
	[Address(RVA = "0x2265CCC", Offset = "0x2265CCC", VA = "0x2265CCC", Slot = "48")]
	public UIVoucherItemController OpenVoucherItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B6D3")]
	[Address(RVA = "0x2265DC4", Offset = "0x2265DC4", VA = "0x2265DC4", Slot = "47")]
	public void OnVoucherItemClick(object[] data)
	{
	}

	[Token(Token = "0x600B6D4")]
	[Address(RVA = "0x2264F84", Offset = "0x2264F84", VA = "0x2264F84")]
	private void SetBeforeVoucherLabel()
	{
	}

	[Token(Token = "0x600B6D5")]
	[Address(RVA = "0x2265F94", Offset = "0x2265F94", VA = "0x2265F94")]
	private void ShowVoucherEffect()
	{
	}

	[Token(Token = "0x600B6D6")]
	[Address(RVA = "0x225358C", Offset = "0x225358C", VA = "0x225358C")]
	protected void InitItemInfo(BaseItemInfo baseItemInfo)
	{
	}

	[Token(Token = "0x600B6D7")]
	[Address(RVA = "0x2252EA0", Offset = "0x2252EA0", VA = "0x2252EA0")]
	protected bool CanShowModifyCountContainer(uint awardTime, uint limited_purchase_times)
	{
		return default(bool);
	}

	[Token(Token = "0x600B6D8")]
	[Address(RVA = "0x2253024", Offset = "0x2253024", VA = "0x2253024")]
	protected void EnableInput(bool enable)
	{
	}

	[Token(Token = "0x600B6D9")]
	[Address(RVA = "0x2266190", Offset = "0x2266190", VA = "0x2266190")]
	private void OnCountInputSubmit()
	{
	}

	[Token(Token = "0x600B6DA")]
	[Address(RVA = "0x226644C", Offset = "0x226644C", VA = "0x226644C")]
	private void RefreshCountInput()
	{
	}

	[Token(Token = "0x600B6DB")]
	[Address(RVA = "0x2266514", Offset = "0x2266514", VA = "0x2266514")]
	private void OnCountInputChanged()
	{
	}

	[Token(Token = "0x600B6DC")]
	[Address(RVA = "0x22667C4", Offset = "0x22667C4", VA = "0x22667C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B6DD")]
	[Address(RVA = "0x22667CC", Offset = "0x22667CC", VA = "0x22667CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
