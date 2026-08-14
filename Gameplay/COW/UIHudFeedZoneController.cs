using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200274B")]
internal class UIHudFeedZoneController : UIBaseController
{
	[Token(Token = "0x400F265")]
	[FieldOffset(Offset = "0x28")]
	private UIHudFeedZoneView m_View;

	[Token(Token = "0x400F266")]
	[FieldOffset(Offset = "0x2C")]
	private ushort m_Feedid;

	[Token(Token = "0x400F267")]
	[FieldOffset(Offset = "0x30")]
	protected float m_EnableFeedTime;

	[Token(Token = "0x400F268")]
	[FieldOffset(Offset = "0x34")]
	private uint m_delaycall;

	[Token(Token = "0x600EFBE")]
	[Address(RVA = "0x1B9AF70", Offset = "0x1B9AF70", VA = "0x1B9AF70")]
	public UIHudFeedZoneController()
	{
	}

	[Token(Token = "0x600EFBF")]
	[Address(RVA = "0x1B9B000", Offset = "0x1B9B000", VA = "0x1B9B000")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EFC0")]
	[Address(RVA = "0x1B9B0A8", Offset = "0x1B9B0A8", VA = "0x1B9B0A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EFC1")]
	[Address(RVA = "0x1B9B298", Offset = "0x1B9B298", VA = "0x1B9B298", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600EFC2")]
	[Address(RVA = "0x1B9B3CC", Offset = "0x1B9B3CC", VA = "0x1B9B3CC")]
	private void OnShowFeedZone(object[] datas)
	{
	}

	[Token(Token = "0x600EFC3")]
	[Address(RVA = "0x1B9B698", Offset = "0x1B9B698", VA = "0x1B9B698")]
	private void OnFeedClick()
	{
	}

	[Token(Token = "0x600EFC4")]
	[Address(RVA = "0x1B9B8BC", Offset = "0x1B9B8BC", VA = "0x1B9B8BC")]
	private void _003COnFeedClick_003Em__0()
	{
	}

	[Token(Token = "0x600EFC5")]
	[Address(RVA = "0x1B9B900", Offset = "0x1B9B900", VA = "0x1B9B900")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EFC6")]
	[Address(RVA = "0x1B9B908", Offset = "0x1B9B908", VA = "0x1B9B908")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
