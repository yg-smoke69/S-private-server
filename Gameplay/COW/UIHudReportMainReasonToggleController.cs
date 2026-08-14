using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002832")]
internal class UIHudReportMainReasonToggleController : UIBaseController
{
	[Token(Token = "0x400F809")]
	[FieldOffset(Offset = "0x28")]
	private UIHudReportMainReasonToggleView m_View;

	[Token(Token = "0x400F80A")]
	[FieldOffset(Offset = "0x2C")]
	private uint reason;

	[Token(Token = "0x400F80B")]
	[FieldOffset(Offset = "0x30")]
	private int m_SubReasonNum;

	[Token(Token = "0x600FAAA")]
	[Address(RVA = "0x13EC424", Offset = "0x13EC424", VA = "0x13EC424")]
	public UIHudReportMainReasonToggleController()
	{
	}

	[Token(Token = "0x600FAAB")]
	[Address(RVA = "0x13EC4A8", Offset = "0x13EC4A8", VA = "0x13EC4A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FAAC")]
	[Address(RVA = "0x13EC564", Offset = "0x13EC564", VA = "0x13EC564")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FAAD")]
	[Address(RVA = "0x13E7318", Offset = "0x13E7318", VA = "0x13E7318")]
	public void SetViewData(string reasonLoc, uint reason, string descLoc)
	{
	}

	[Token(Token = "0x600FAAE")]
	[Address(RVA = "0x13E6CC0", Offset = "0x13E6CC0", VA = "0x13E6CC0")]
	public uint GetSelectedReason()
	{
		return default(uint);
	}

	[Token(Token = "0x600FAAF")]
	[Address(RVA = "0x13E6E4C", Offset = "0x13E6E4C", VA = "0x13E6E4C")]
	public void MainReasonToggleOnClick()
	{
	}

	[Token(Token = "0x600FAB0")]
	[Address(RVA = "0x13E8358", Offset = "0x13E8358", VA = "0x13E8358")]
	public void DisableToggle()
	{
	}

	[Token(Token = "0x600FAB1")]
	[Address(RVA = "0x13E6D18", Offset = "0x13E6D18", VA = "0x13E6D18")]
	public void InitSelectCallBack()
	{
	}

	[Token(Token = "0x600FAB2")]
	[Address(RVA = "0x13E6C50", Offset = "0x13E6C50", VA = "0x13E6C50")]
	public UIToggleButton GetToggle()
	{
		return null;
	}

	[Token(Token = "0x600FAB3")]
	[Address(RVA = "0x13E78D4", Offset = "0x13E78D4", VA = "0x13E78D4")]
	public UIGrid GetGrid()
	{
		return null;
	}

	[Token(Token = "0x600FAB4")]
	[Address(RVA = "0x13E89A4", Offset = "0x13E89A4", VA = "0x13E89A4")]
	public void SetSelectState(bool v)
	{
	}

	[Token(Token = "0x600FAB5")]
	[Address(RVA = "0x13EB89C", Offset = "0x13EB89C", VA = "0x13EB89C")]
	public void SetSubReasonNum(int num)
	{
	}

	[Token(Token = "0x600FAB6")]
	[Address(RVA = "0x13EC60C", Offset = "0x13EC60C", VA = "0x13EC60C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
