using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002833")]
internal class UIHudReportSubReasonToggleController : UIBaseController
{
	[Token(Token = "0x400F80C")]
	[FieldOffset(Offset = "0x28")]
	private UIHudReportSubReasonToggleView m_View;

	[Token(Token = "0x400F80D")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_SubReportReason;

	[Token(Token = "0x600FAB7")]
	[Address(RVA = "0x13ED2FC", Offset = "0x13ED2FC", VA = "0x13ED2FC")]
	public UIHudReportSubReasonToggleController()
	{
	}

	[Token(Token = "0x600FAB8")]
	[Address(RVA = "0x13ED380", Offset = "0x13ED380", VA = "0x13ED380")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FAB9")]
	[Address(RVA = "0x13ED428", Offset = "0x13ED428", VA = "0x13ED428", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FABA")]
	[Address(RVA = "0x13E7944", Offset = "0x13E7944", VA = "0x13E7944")]
	public void SetViewData(string subReasonLoc, uint subReason)
	{
	}

	[Token(Token = "0x600FABB")]
	[Address(RVA = "0x13E7F54", Offset = "0x13E7F54", VA = "0x13E7F54")]
	public uint GetSubReason()
	{
		return default(uint);
	}

	[Token(Token = "0x600FABC")]
	[Address(RVA = "0x13E8E1C", Offset = "0x13E8E1C", VA = "0x13E8E1C")]
	public void SetSubReasonUnselect()
	{
	}

	[Token(Token = "0x600FABD")]
	[Address(RVA = "0x13ED4E4", Offset = "0x13ED4E4", VA = "0x13ED4E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
