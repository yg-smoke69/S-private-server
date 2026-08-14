using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BFB")]
internal class UIWaitForCoolDownController : UIBaseController
{
	[Token(Token = "0x4010CAD")]
	[FieldOffset(Offset = "0x28")]
	private UIWaitingCoolDownView m_View;

	[Token(Token = "0x4010CAE")]
	[FieldOffset(Offset = "0x2C")]
	private int CoolDownSeconds;

	[Token(Token = "0x4010CAF")]
	[FieldOffset(Offset = "0x30")]
	private float m_Time;

	[Token(Token = "0x4010CB0")]
	[FieldOffset(Offset = "0x34")]
	private int m_SecondsLeft;

	[Token(Token = "0x60123F3")]
	[Address(RVA = "0x101BAA4", Offset = "0x101BAA4", VA = "0x101BAA4")]
	public UIWaitForCoolDownController()
	{
	}

	[Token(Token = "0x60123F4")]
	[Address(RVA = "0x101BB34", Offset = "0x101BB34", VA = "0x101BB34")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60123F5")]
	[Address(RVA = "0x101BBD8", Offset = "0x101BBD8", VA = "0x101BBD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60123F6")]
	[Address(RVA = "0x101BC94", Offset = "0x101BC94", VA = "0x101BC94")]
	private void Update()
	{
	}

	[Token(Token = "0x60123F7")]
	[Address(RVA = "0x101BEA0", Offset = "0x101BEA0", VA = "0x101BEA0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
