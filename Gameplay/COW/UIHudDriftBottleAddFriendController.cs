using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002731")]
public class UIHudDriftBottleAddFriendController : UIBaseController
{
	[Token(Token = "0x2002732")]
	private sealed class _003CShowMessage_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F1E9")]
		[FieldOffset(Offset = "0x8")]
		internal float closeTime;

		[Token(Token = "0x400F1EA")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudDriftBottleAddFriendController _0024this;

		[Token(Token = "0x600EEAC")]
		[Address(RVA = "0x1CD7F84", Offset = "0x1CD7F84", VA = "0x1CD7F84")]
		public _003CShowMessage_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600EEAD")]
		[Address(RVA = "0x1CD84DC", Offset = "0x1CD84DC", VA = "0x1CD84DC")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600EEAE")]
		[Address(RVA = "0x1CD8510", Offset = "0x1CD8510", VA = "0x1CD8510")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400F1E4")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDriftBottleAddFriendView m_View;

	[Token(Token = "0x400F1E5")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelFriends m_Model;

	[Token(Token = "0x400F1E6")]
	[FieldOffset(Offset = "0x30")]
	private uint m_CloseDelayCallID;

	[Token(Token = "0x400F1E7")]
	[FieldOffset(Offset = "0x34")]
	private uint m_TimeDelayCallID;

	[Token(Token = "0x400F1E8")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_BindUserID;

	[Token(Token = "0x600EEA3")]
	[Address(RVA = "0x1CD77CC", Offset = "0x1CD77CC", VA = "0x1CD77CC")]
	public UIHudDriftBottleAddFriendController()
	{
	}

	[Token(Token = "0x600EEA4")]
	[Address(RVA = "0x1CD7850", Offset = "0x1CD7850", VA = "0x1CD7850")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EEA5")]
	[Address(RVA = "0x1CD78F8", Offset = "0x1CD78F8", VA = "0x1CD78F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EEA6")]
	[Address(RVA = "0x1CD7B38", Offset = "0x1CD7B38", VA = "0x1CD7B38")]
	public void ShowMessage(ulong userID, string userName)
	{
	}

	[Token(Token = "0x600EEA7")]
	[Address(RVA = "0x1CD7F8C", Offset = "0x1CD7F8C", VA = "0x1CD7F8C")]
	private void OnOkBtnClick()
	{
	}

	[Token(Token = "0x600EEA8")]
	[Address(RVA = "0x1CD819C", Offset = "0x1CD819C", VA = "0x1CD819C")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600EEA9")]
	[Address(RVA = "0x1CD8318", Offset = "0x1CD8318", VA = "0x1CD8318", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EEAA")]
	[Address(RVA = "0x1CD84CC", Offset = "0x1CD84CC", VA = "0x1CD84CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EEAB")]
	[Address(RVA = "0x1CD84D4", Offset = "0x1CD84D4", VA = "0x1CD84D4")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
