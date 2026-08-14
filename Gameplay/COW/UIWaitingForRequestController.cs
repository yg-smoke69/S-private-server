using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BFD")]
internal class UIWaitingForRequestController : UIBaseController
{
	[Token(Token = "0x4010CB1")]
	[FieldOffset(Offset = "0x28")]
	private UIWaitingForRequestView m_View;

	[Token(Token = "0x4010CB2")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_WaitingTimeState;

	[Token(Token = "0x4010CB3")]
	[FieldOffset(Offset = "0x30")]
	private float m_WaitingTime;

	[Token(Token = "0x4010CB4")]
	[FieldOffset(Offset = "0x34")]
	public bool ActiveState;

	[Token(Token = "0x60123FA")]
	[Address(RVA = "0x101C064", Offset = "0x101C064", VA = "0x101C064")]
	public UIWaitingForRequestController()
	{
	}

	[Token(Token = "0x60123FB")]
	[Address(RVA = "0x101C18C", Offset = "0x101C18C", VA = "0x101C18C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60123FC")]
	[Address(RVA = "0x101C230", Offset = "0x101C230", VA = "0x101C230", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60123FD")]
	[Address(RVA = "0x101C2EC", Offset = "0x101C2EC", VA = "0x101C2EC")]
	public void SetBlockClick(bool flag)
	{
	}

	[Token(Token = "0x60123FE")]
	[Address(RVA = "0x101C47C", Offset = "0x101C47C", VA = "0x101C47C")]
	private void Update()
	{
	}

	[Token(Token = "0x60123FF")]
	[Address(RVA = "0x101C3E4", Offset = "0x101C3E4", VA = "0x101C3E4")]
	public void ShowRoot(bool isShow)
	{
	}

	[Token(Token = "0x6012400")]
	[Address(RVA = "0x101C5C0", Offset = "0x101C5C0", VA = "0x101C5C0")]
	public void RequestFinish()
	{
	}

	[Token(Token = "0x6012401")]
	[Address(RVA = "0x101C634", Offset = "0x101C634", VA = "0x101C634")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
