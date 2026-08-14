using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E89")]
public class UIBigEventFriendReunionInviteeController : UIBaseController
{
	[Token(Token = "0x2001E8A")]
	private sealed class _003COnClaimButtonClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C00D")]
		[FieldOffset(Offset = "0x8")]
		internal ulong inviter;

		[Token(Token = "0x400C00E")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelActivity modelActivity;

		[Token(Token = "0x400C00F")]
		[FieldOffset(Offset = "0x14")]
		internal UIBigEventFriendReunionInviteeController _0024this;

		[Token(Token = "0x600930A")]
		[Address(RVA = "0x141BC90", Offset = "0x141BC90", VA = "0x141BC90")]
		public _003COnClaimButtonClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600930B")]
		[Address(RVA = "0x141BE18", Offset = "0x141BE18", VA = "0x141BE18")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x600930C")]
		[Address(RVA = "0x141BE58", Offset = "0x141BE58", VA = "0x141BE58")]
		internal void _003C_003Em__1(AccountInfoBasic basic)
		{
		}

		[Token(Token = "0x600930D")]
		[Address(RVA = "0x141C1E4", Offset = "0x141C1E4", VA = "0x141C1E4")]
		internal void _003C_003Em__2()
		{
		}
	}

	[Token(Token = "0x400C00A")]
	[FieldOffset(Offset = "0x28")]
	private UIBigEventFriendReunionInviteeView m_View;

	[Token(Token = "0x400C00B")]
	[FieldOffset(Offset = "0x2C")]
	private ActivityGroupDesc m_Data;

	[Token(Token = "0x400C00C")]
	[FieldOffset(Offset = "0x30")]
	private UIWidget m_ButtonWidget;

	[Token(Token = "0x60092FE")]
	[Address(RVA = "0x141A7B4", Offset = "0x141A7B4", VA = "0x141A7B4")]
	public UIBigEventFriendReunionInviteeController()
	{
	}

	[Token(Token = "0x60092FF")]
	[Address(RVA = "0x141A838", Offset = "0x141A838", VA = "0x141A838")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009300")]
	[Address(RVA = "0x141A8E0", Offset = "0x141A8E0", VA = "0x141A8E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009301")]
	[Address(RVA = "0x141AE70", Offset = "0x141AE70", VA = "0x141AE70", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6009302")]
	[Address(RVA = "0x14195FC", Offset = "0x14195FC", VA = "0x14195FC")]
	public void SetData(ActivityGroupDesc activityGroupDesc, string inviterUID, bool gained = false)
	{
	}

	[Token(Token = "0x6009303")]
	[Address(RVA = "0x141B104", Offset = "0x141B104", VA = "0x141B104")]
	private void OnInvitationInputGetFocus()
	{
	}

	[Token(Token = "0x6009304")]
	[Address(RVA = "0x141AFA4", Offset = "0x141AFA4", VA = "0x141AFA4")]
	private void OnInvitationInputLostFocus()
	{
	}

	[Token(Token = "0x6009305")]
	[Address(RVA = "0x141AC78", Offset = "0x141AC78", VA = "0x141AC78")]
	private void OnInvitationInputChanged()
	{
	}

	[Token(Token = "0x6009306")]
	[Address(RVA = "0x141B1B4", Offset = "0x141B1B4", VA = "0x141B1B4")]
	private void OnClaimButtonClick()
	{
	}

	[Token(Token = "0x6009307")]
	[Address(RVA = "0x141BC98", Offset = "0x141BC98", VA = "0x141BC98")]
	private void OnRewriteID(object[] data)
	{
	}

	[Token(Token = "0x6009308")]
	[Address(RVA = "0x141BE08", Offset = "0x141BE08", VA = "0x141BE08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009309")]
	[Address(RVA = "0x141BE10", Offset = "0x141BE10", VA = "0x141BE10")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
