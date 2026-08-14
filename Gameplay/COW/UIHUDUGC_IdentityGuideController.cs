using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002897")]
internal class UIHUDUGC_IdentityGuideController : UIBaseController
{
	[Token(Token = "0x400F9F5")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_IdentityGuideView m_View;

	[Token(Token = "0x400F9F6")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCall;

	[Token(Token = "0x400F9F7")]
	[FieldOffset(Offset = "0x30")]
	private int m_CurrentIdentity;

	[Token(Token = "0x600FEDD")]
	[Address(RVA = "0x2E08A00", Offset = "0x2E08A00", VA = "0x2E08A00")]
	public UIHUDUGC_IdentityGuideController()
	{
	}

	[Token(Token = "0x600FEDE")]
	[Address(RVA = "0x2E08A84", Offset = "0x2E08A84", VA = "0x2E08A84")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FEDF")]
	[Address(RVA = "0x2E08B2C", Offset = "0x2E08B2C", VA = "0x2E08B2C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FEE0")]
	[Address(RVA = "0x2E08C48", Offset = "0x2E08C48", VA = "0x2E08C48", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600FEE1")]
	[Address(RVA = "0x2E08D50", Offset = "0x2E08D50", VA = "0x2E08D50")]
	public void SetViewData(int identity)
	{
	}

	[Token(Token = "0x600FEE2")]
	[Address(RVA = "0x2E0914C", Offset = "0x2E0914C", VA = "0x2E0914C")]
	private void OnFactionChanged(object[] data)
	{
	}

	[Token(Token = "0x600FEE3")]
	[Address(RVA = "0x2E09314", Offset = "0x2E09314", VA = "0x2E09314")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x600FEE4")]
	[Address(RVA = "0x2E093D8", Offset = "0x2E093D8", VA = "0x2E093D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FEE5")]
	[Address(RVA = "0x2E093E0", Offset = "0x2E093E0", VA = "0x2E093E0")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
