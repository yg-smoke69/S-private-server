using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C30")]
public class UIMallVoucherController : UIVoucherController
{
	[Token(Token = "0x4010DC2")]
	[FieldOffset(Offset = "0x38")]
	private UIMallVoucherView m_View;

	[Token(Token = "0x4010DC3")]
	[FieldOffset(Offset = "0x3C")]
	private UIVoucherListController m_Ctrl;

	[Token(Token = "0x4010DC4")]
	[FieldOffset(Offset = "0x40")]
	private List<VoucherData> m_VoucherData;

	[Token(Token = "0x60126AC")]
	[Address(RVA = "0x226BAD8", Offset = "0x226BAD8", VA = "0x226BAD8")]
	public UIMallVoucherController()
	{
	}

	[Token(Token = "0x60126AD")]
	[Address(RVA = "0x226BB64", Offset = "0x226BB64", VA = "0x226BB64")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60126AE")]
	[Address(RVA = "0x226BC0C", Offset = "0x226BC0C", VA = "0x226BC0C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60126AF")]
	[Address(RVA = "0x226C2AC", Offset = "0x226C2AC", VA = "0x226C2AC", Slot = "35")]
	public override void SetVoucher(uint gemsPrice, uint coinsPrice)
	{
	}

	[Token(Token = "0x60126B0")]
	[Address(RVA = "0x226D270", Offset = "0x226D270", VA = "0x226D270", Slot = "31")]
	public override void OnVoucherListClose(object[] data)
	{
	}

	[Token(Token = "0x60126B1")]
	[Address(RVA = "0x226D344", Offset = "0x226D344", VA = "0x226D344", Slot = "32")]
	public override void OnVoucherItemClick(object[] data)
	{
	}

	[Token(Token = "0x60126B2")]
	[Address(RVA = "0x226D950", Offset = "0x226D950", VA = "0x226D950", Slot = "33")]
	public override void OnVoucherBtnClick()
	{
	}

	[Token(Token = "0x60126B3")]
	[Address(RVA = "0x226DCF0", Offset = "0x226DCF0", VA = "0x226DCF0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60126B4")]
	[Address(RVA = "0x226DE8C", Offset = "0x226DE8C", VA = "0x226DE8C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60126B5")]
	[Address(RVA = "0x226DE94", Offset = "0x226DE94", VA = "0x226DE94")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
