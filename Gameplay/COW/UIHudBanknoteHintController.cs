using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026E0")]
public class UIHudBanknoteHintController : UIBaseController
{
	[Token(Token = "0x400F02C")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBanknoteHintView m_View;

	[Token(Token = "0x400F02D")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ControlTargetTime;

	[Token(Token = "0x400F02E")]
	[FieldOffset(Offset = "0x30")]
	private int m_LastSecond;

	[Token(Token = "0x400F02F")]
	[FieldOffset(Offset = "0x34")]
	private StringBuilder m_HintText;

	[Token(Token = "0x600EB79")]
	[Address(RVA = "0x17149FC", Offset = "0x17149FC", VA = "0x17149FC")]
	public UIHudBanknoteHintController()
	{
	}

	[Token(Token = "0x600EB7A")]
	[Address(RVA = "0x1714AA4", Offset = "0x1714AA4", VA = "0x1714AA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB7B")]
	[Address(RVA = "0x1714B48", Offset = "0x1714B48", VA = "0x1714B48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB7C")]
	[Address(RVA = "0x1714CAC", Offset = "0x1714CAC", VA = "0x1714CAC")]
	private void LocalBeginTryControl(object[] data)
	{
	}

	[Token(Token = "0x600EB7D")]
	[Address(RVA = "0x1714E28", Offset = "0x1714E28", VA = "0x1714E28")]
	private void StopTryingControlCountDown()
	{
	}

	[Token(Token = "0x600EB7E")]
	[Address(RVA = "0x1714EA0", Offset = "0x1714EA0", VA = "0x1714EA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600EB7F")]
	[Address(RVA = "0x1715144", Offset = "0x1715144", VA = "0x1715144")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
