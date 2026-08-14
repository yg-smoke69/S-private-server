using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F5E")]
public class UIActivityFriendReunionInviteeController : UIBaseController
{
	[Token(Token = "0x2001F5F")]
	private sealed class _003COnClaimButtonClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C515")]
		[FieldOffset(Offset = "0x8")]
		internal ulong inviter;

		[Token(Token = "0x400C516")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelActivity modelActivity;

		[Token(Token = "0x400C517")]
		[FieldOffset(Offset = "0x14")]
		internal UIActivityFriendReunionInviteeController _0024this;

		[Token(Token = "0x6009B60")]
		[Address(RVA = "0x2FB1060", Offset = "0x2FB1060", VA = "0x2FB1060")]
		public _003COnClaimButtonClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009B61")]
		[Address(RVA = "0x2FB11E8", Offset = "0x2FB11E8", VA = "0x2FB11E8")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x6009B62")]
		[Address(RVA = "0x2FB1228", Offset = "0x2FB1228", VA = "0x2FB1228")]
		internal void _003C_003Em__1(AccountInfoBasic basic)
		{
		}

		[Token(Token = "0x6009B63")]
		[Address(RVA = "0x2FB15B4", Offset = "0x2FB15B4", VA = "0x2FB15B4")]
		internal void _003C_003Em__2()
		{
		}
	}

	[Token(Token = "0x400C512")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityFriendReunionInviteeView m_View;

	[Token(Token = "0x400C513")]
	[FieldOffset(Offset = "0x2C")]
	private ActivityGroupDesc m_Data;

	[Token(Token = "0x400C514")]
	[FieldOffset(Offset = "0x30")]
	private UIWidget m_ButtonWidget;

	[Token(Token = "0x6009B54")]
	[Address(RVA = "0x2FAFB84", Offset = "0x2FAFB84", VA = "0x2FAFB84")]
	public UIActivityFriendReunionInviteeController()
	{
	}

	[Token(Token = "0x6009B55")]
	[Address(RVA = "0x2FAFC08", Offset = "0x2FAFC08", VA = "0x2FAFC08")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B56")]
	[Address(RVA = "0x2FAFCB0", Offset = "0x2FAFCB0", VA = "0x2FAFCB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B57")]
	[Address(RVA = "0x2FB0240", Offset = "0x2FB0240", VA = "0x2FB0240", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6009B58")]
	[Address(RVA = "0x2FAEEBC", Offset = "0x2FAEEBC", VA = "0x2FAEEBC")]
	public void SetData(ActivityGroupDesc activityGroupDesc, string inviterUID, bool gained = false)
	{
	}

	[Token(Token = "0x6009B59")]
	[Address(RVA = "0x2FB04D4", Offset = "0x2FB04D4", VA = "0x2FB04D4")]
	private void OnInvitationInputGetFocus()
	{
	}

	[Token(Token = "0x6009B5A")]
	[Address(RVA = "0x2FB0374", Offset = "0x2FB0374", VA = "0x2FB0374")]
	private void OnInvitationInputLostFocus()
	{
	}

	[Token(Token = "0x6009B5B")]
	[Address(RVA = "0x2FB0048", Offset = "0x2FB0048", VA = "0x2FB0048")]
	private void OnInvitationInputChanged()
	{
	}

	[Token(Token = "0x6009B5C")]
	[Address(RVA = "0x2FB0584", Offset = "0x2FB0584", VA = "0x2FB0584")]
	private void OnClaimButtonClick()
	{
	}

	[Token(Token = "0x6009B5D")]
	[Address(RVA = "0x2FB1068", Offset = "0x2FB1068", VA = "0x2FB1068")]
	private void OnRewriteID(object[] data)
	{
	}

	[Token(Token = "0x6009B5E")]
	[Address(RVA = "0x2FB11D8", Offset = "0x2FB11D8", VA = "0x2FB11D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009B5F")]
	[Address(RVA = "0x2FB11E0", Offset = "0x2FB11E0", VA = "0x2FB11E0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
