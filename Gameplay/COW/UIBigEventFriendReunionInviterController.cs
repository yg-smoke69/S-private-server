using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E8B")]
public class UIBigEventFriendReunionInviterController : UIBaseController
{
	[Token(Token = "0x400C010")]
	[FieldOffset(Offset = "0x28")]
	private UIBigEventFriendReunionInviterView m_View;

	[Token(Token = "0x400C011")]
	[FieldOffset(Offset = "0x2C")]
	private UICountDownController m_CDControler;

	[Token(Token = "0x600930E")]
	[Address(RVA = "0x141C6F0", Offset = "0x141C6F0", VA = "0x141C6F0")]
	public UIBigEventFriendReunionInviterController()
	{
	}

	[Token(Token = "0x600930F")]
	[Address(RVA = "0x141C774", Offset = "0x141C774", VA = "0x141C774")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009310")]
	[Address(RVA = "0x141C81C", Offset = "0x141C81C", VA = "0x141C81C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009311")]
	[Address(RVA = "0x141C9C4", Offset = "0x141C9C4", VA = "0x141C9C4")]
	public void SetData(ActivityGroupDesc activityGroupDesc)
	{
	}

	[Token(Token = "0x6009312")]
	[Address(RVA = "0x141CA20", Offset = "0x141CA20", VA = "0x141CA20")]
	public void SetProgress(int current, int max)
	{
	}

	[Token(Token = "0x6009313")]
	[Address(RVA = "0x141CBE8", Offset = "0x141CBE8", VA = "0x141CBE8")]
	public void UpdateData(ulong endsAt)
	{
	}

	[Token(Token = "0x6009314")]
	[Address(RVA = "0x141CD60", Offset = "0x141CD60", VA = "0x141CD60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
