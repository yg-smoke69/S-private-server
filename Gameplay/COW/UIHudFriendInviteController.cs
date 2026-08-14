using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023DF")]
public class UIHudFriendInviteController : UIBaseController
{
	[Token(Token = "0x400DEEB")]
	[FieldOffset(Offset = "0x28")]
	private UIHudFriendinviteView m_View;

	[Token(Token = "0x400DEEC")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelFriends m_Model;

	[Token(Token = "0x400DEED")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsIgnore;

	[Token(Token = "0x400DEEE")]
	[FieldOffset(Offset = "0x34")]
	private uint m_CloseDelayCallID;

	[Token(Token = "0x400DEEF")]
	[FieldOffset(Offset = "0x38")]
	private uint m_TimeDelayCallID;

	[Token(Token = "0x400DEF0")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_AutoDisagreeTimeStamp;

	[Token(Token = "0x400DEF1")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_BindUserID;

	[Token(Token = "0x600CA72")]
	[Address(RVA = "0x1885708", Offset = "0x1885708", VA = "0x1885708")]
	public UIHudFriendInviteController()
	{
	}

	[Token(Token = "0x600CA73")]
	[Address(RVA = "0x188578C", Offset = "0x188578C", VA = "0x188578C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA74")]
	[Address(RVA = "0x1885830", Offset = "0x1885830", VA = "0x1885830", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA75")]
	[Address(RVA = "0x1885B24", Offset = "0x1885B24", VA = "0x1885B24")]
	public void BindPlayer(ulong user_id)
	{
	}

	[Token(Token = "0x600CA76")]
	[Address(RVA = "0x1886104", Offset = "0x1886104", VA = "0x1886104")]
	private void OnAgreeBtnClick()
	{
	}

	[Token(Token = "0x600CA77")]
	[Address(RVA = "0x1886480", Offset = "0x1886480", VA = "0x1886480")]
	private void OnDisAgreeBtnClick()
	{
	}

	[Token(Token = "0x600CA78")]
	[Address(RVA = "0x1886338", Offset = "0x1886338", VA = "0x1886338")]
	private void OnInviteChecked()
	{
	}

	[Token(Token = "0x600CA79")]
	[Address(RVA = "0x18866B4", Offset = "0x18866B4", VA = "0x18866B4")]
	private void OnIgnoreToggleClick()
	{
	}

	[Token(Token = "0x600CA7A")]
	[Address(RVA = "0x188675C", Offset = "0x188675C", VA = "0x188675C")]
	private void _003CBindPlayer_003Em__0()
	{
	}

	[Token(Token = "0x600CA7B")]
	[Address(RVA = "0x1886768", Offset = "0x1886768", VA = "0x1886768")]
	private void _003CBindPlayer_003Em__1()
	{
	}

	[Token(Token = "0x600CA7C")]
	[Address(RVA = "0x1886900", Offset = "0x1886900", VA = "0x1886900")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
