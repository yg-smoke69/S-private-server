using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022B1")]
public class UIHudPVEAutoReviveController : UIBaseController
{
	[Token(Token = "0x400D90C")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDPVEAutoReviveInfoView m_view;

	[Token(Token = "0x400D90D")]
	[FieldOffset(Offset = "0x2C")]
	private float m_LeftTime;

	[Token(Token = "0x600BEC3")]
	[Address(RVA = "0x183945C", Offset = "0x183945C", VA = "0x183945C")]
	public UIHudPVEAutoReviveController()
	{
	}

	[Token(Token = "0x600BEC4")]
	[Address(RVA = "0x18394E0", Offset = "0x18394E0", VA = "0x18394E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BEC5")]
	[Address(RVA = "0x1839584", Offset = "0x1839584", VA = "0x1839584", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BEC6")]
	[Address(RVA = "0x18396B0", Offset = "0x18396B0", VA = "0x18396B0")]
	public void SetUIData(bool isTeamKill, int leftTime)
	{
	}

	[Token(Token = "0x600BEC7")]
	[Address(RVA = "0x18397A8", Offset = "0x18397A8", VA = "0x18397A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600BEC8")]
	[Address(RVA = "0x18399E8", Offset = "0x18399E8", VA = "0x18399E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
