using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F60")]
public class UIActivityFriendReunionInviterController : UIBaseController
{
	[Token(Token = "0x400C518")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityFriendReunionInviterView m_View;

	[Token(Token = "0x400C519")]
	[FieldOffset(Offset = "0x2C")]
	private UICountDownController m_CDControler;

	[Token(Token = "0x6009B64")]
	[Address(RVA = "0x2FB1AC0", Offset = "0x2FB1AC0", VA = "0x2FB1AC0")]
	public UIActivityFriendReunionInviterController()
	{
	}

	[Token(Token = "0x6009B65")]
	[Address(RVA = "0x2FB1B44", Offset = "0x2FB1B44", VA = "0x2FB1B44")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B66")]
	[Address(RVA = "0x2FB1BEC", Offset = "0x2FB1BEC", VA = "0x2FB1BEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B67")]
	[Address(RVA = "0x2FB1D94", Offset = "0x2FB1D94", VA = "0x2FB1D94")]
	public void SetWidth(int width)
	{
	}

	[Token(Token = "0x6009B68")]
	[Address(RVA = "0x2FB1E2C", Offset = "0x2FB1E2C", VA = "0x2FB1E2C")]
	public void SetData(ActivityGroupDesc activityGroupDesc)
	{
	}

	[Token(Token = "0x6009B69")]
	[Address(RVA = "0x2FB1E88", Offset = "0x2FB1E88", VA = "0x2FB1E88")]
	public void SetProgress(int current, int max)
	{
	}

	[Token(Token = "0x6009B6A")]
	[Address(RVA = "0x2FB2050", Offset = "0x2FB2050", VA = "0x2FB2050")]
	public void UpdateData(ulong endsAt)
	{
	}

	[Token(Token = "0x6009B6B")]
	[Address(RVA = "0x2FB21C8", Offset = "0x2FB21C8", VA = "0x2FB21C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
