using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022B0")]
public class UIHUDPlayerGodBarController : UIBaseController
{
	[Token(Token = "0x400D908")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDPlayerGodBarView m_View;

	[Token(Token = "0x400D909")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsGoding;

	[Token(Token = "0x400D90A")]
	[FieldOffset(Offset = "0x30")]
	private float m_GodBeginTime;

	[Token(Token = "0x400D90B")]
	[FieldOffset(Offset = "0x34")]
	private float m_GodEndTime;

	[Token(Token = "0x600BEB9")]
	[Address(RVA = "0x1686274", Offset = "0x1686274", VA = "0x1686274")]
	public UIHUDPlayerGodBarController()
	{
	}

	[Token(Token = "0x600BEBA")]
	[Address(RVA = "0x16862F8", Offset = "0x16862F8", VA = "0x16862F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BEBB")]
	[Address(RVA = "0x168639C", Offset = "0x168639C", VA = "0x168639C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BEBC")]
	[Address(RVA = "0x1686554", Offset = "0x1686554", VA = "0x1686554", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BEBD")]
	[Address(RVA = "0x16866F0", Offset = "0x16866F0", VA = "0x16866F0")]
	private void OnShowGod(object[] data)
	{
	}

	[Token(Token = "0x600BEBE")]
	[Address(RVA = "0x1686830", Offset = "0x1686830", VA = "0x1686830")]
	public void OnGodBegin(float godEndTime)
	{
	}

	[Token(Token = "0x600BEBF")]
	[Address(RVA = "0x16869A0", Offset = "0x16869A0", VA = "0x16869A0")]
	private void Update()
	{
	}

	[Token(Token = "0x600BEC0")]
	[Address(RVA = "0x1686B78", Offset = "0x1686B78", VA = "0x1686B78")]
	private void OnSightingStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600BEC1")]
	[Address(RVA = "0x1686CB0", Offset = "0x1686CB0", VA = "0x1686CB0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BEC2")]
	[Address(RVA = "0x1686CB8", Offset = "0x1686CB8", VA = "0x1686CB8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
