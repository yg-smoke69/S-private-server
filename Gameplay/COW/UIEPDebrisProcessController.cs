using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020D3")]
public class UIEPDebrisProcessController : UIBaseController
{
	[Token(Token = "0x400CD75")]
	[FieldOffset(Offset = "0x28")]
	private UIEPDebrisProcessView m_View;

	[Token(Token = "0x400CD76")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelElitePass m_Model;

	[Token(Token = "0x600A9D8")]
	[Address(RVA = "0x2BAADF0", Offset = "0x2BAADF0", VA = "0x2BAADF0")]
	public UIEPDebrisProcessController()
	{
	}

	[Token(Token = "0x600A9D9")]
	[Address(RVA = "0x2BAAE74", Offset = "0x2BAAE74", VA = "0x2BAAE74")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A9DA")]
	[Address(RVA = "0x2BAAF18", Offset = "0x2BAAF18", VA = "0x2BAAF18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A9DB")]
	[Address(RVA = "0x2BAB290", Offset = "0x2BAB290", VA = "0x2BAB290", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A9DC")]
	[Address(RVA = "0x2BAB10C", Offset = "0x2BAB10C", VA = "0x2BAB10C")]
	private void InitData()
	{
	}

	[Token(Token = "0x600A9DD")]
	[Address(RVA = "0x2BAB3F0", Offset = "0x2BAB3F0", VA = "0x2BAB3F0")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x600A9DE")]
	[Address(RVA = "0x2BAB664", Offset = "0x2BAB664", VA = "0x2BAB664")]
	private void OnEpLevelUpdate(object[] data)
	{
	}

	[Token(Token = "0x600A9DF")]
	[Address(RVA = "0x2BAB6CC", Offset = "0x2BAB6CC", VA = "0x2BAB6CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A9E0")]
	[Address(RVA = "0x2BAB6D4", Offset = "0x2BAB6D4", VA = "0x2BAB6D4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
