using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027A3")]
public class UIHudLocalPlayerKilledController : UIBaseController
{
	[Token(Token = "0x400F4B6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLocalPlayerKilledView m_View;

	[Token(Token = "0x400F4B7")]
	[FieldOffset(Offset = "0x2C")]
	private UIBaseProfileInfoController m_Profile;

	[Token(Token = "0x400F4B8")]
	[FieldOffset(Offset = "0x30")]
	private TypewriterEffect m_WriterEffect;

	[Token(Token = "0x400F4B9")]
	private const float C_ALPHA_BLEND_TIME = 2f;

	[Token(Token = "0x400F4BA")]
	[FieldOffset(Offset = "0x34")]
	private float m_alphaBlendTime;

	[Token(Token = "0x600F468")]
	[Address(RVA = "0xFECBF4", Offset = "0xFECBF4", VA = "0xFECBF4")]
	public UIHudLocalPlayerKilledController()
	{
	}

	[Token(Token = "0x600F469")]
	[Address(RVA = "0xFECC78", Offset = "0xFECC78", VA = "0xFECC78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F46A")]
	[Address(RVA = "0xFECD20", Offset = "0xFECD20", VA = "0xFECD20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F46B")]
	[Address(RVA = "0xFECF2C", Offset = "0xFECF2C", VA = "0xFECF2C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F46C")]
	[Address(RVA = "0xFED060", Offset = "0xFED060", VA = "0xFED060")]
	public void OnLocalPlayerKilled(object[] data)
	{
	}

	[Token(Token = "0x600F46D")]
	[Address(RVA = "0xFEDA50", Offset = "0xFEDA50", VA = "0xFEDA50")]
	private void Update()
	{
	}

	[Token(Token = "0x600F46E")]
	[Address(RVA = "0xFEDC28", Offset = "0xFEDC28", VA = "0xFEDC28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F46F")]
	[Address(RVA = "0xFEDC30", Offset = "0xFEDC30", VA = "0xFEDC30")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
