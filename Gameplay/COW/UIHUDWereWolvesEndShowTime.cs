using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C42")]
public class UIHUDWereWolvesEndShowTime : UIBaseController
{
	[Token(Token = "0x4010E16")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDWereWolvesEndShowTimeView m_View;

	[Token(Token = "0x4010E17")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsWolf;

	[Token(Token = "0x4010E18")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_IsRefreshOver;

	[Token(Token = "0x601275A")]
	[Address(RVA = "0x161F2E4", Offset = "0x161F2E4", VA = "0x161F2E4")]
	public UIHUDWereWolvesEndShowTime()
	{
	}

	[Token(Token = "0x601275B")]
	[Address(RVA = "0x161F368", Offset = "0x161F368", VA = "0x161F368")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601275C")]
	[Address(RVA = "0x161F410", Offset = "0x161F410", VA = "0x161F410", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601275D")]
	[Address(RVA = "0x161FDB8", Offset = "0x161FDB8", VA = "0x161FDB8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601275E")]
	[Address(RVA = "0x161F85C", Offset = "0x161F85C", VA = "0x161F85C")]
	private void RefreshGameOverFlag(object[] param)
	{
	}

	[Token(Token = "0x601275F")]
	[Address(RVA = "0x161FEEC", Offset = "0x161FEEC", VA = "0x161FEEC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012760")]
	[Address(RVA = "0x161FEF4", Offset = "0x161FEF4", VA = "0x161FEF4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
