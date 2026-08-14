using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023DE")]
public class UIHudFriendAddController : UIBaseController
{
	[Token(Token = "0x400DEE6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudFriendaddView m_View;

	[Token(Token = "0x400DEE7")]
	[FieldOffset(Offset = "0x2C")]
	private UIBaseProfileInfoController m_Profile;

	[Token(Token = "0x400DEE8")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_BindAccountID;

	[Token(Token = "0x400DEE9")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsFriend;

	[Token(Token = "0x400DEEA")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_DelayCallID;

	[Token(Token = "0x600CA6B")]
	[Address(RVA = "0x1884BF4", Offset = "0x1884BF4", VA = "0x1884BF4")]
	public UIHudFriendAddController()
	{
	}

	[Token(Token = "0x600CA6C")]
	[Address(RVA = "0x1884C78", Offset = "0x1884C78", VA = "0x1884C78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA6D")]
	[Address(RVA = "0x1884D1C", Offset = "0x1884D1C", VA = "0x1884D1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA6E")]
	[Address(RVA = "0x1884F98", Offset = "0x1884F98", VA = "0x1884F98")]
	public void BindPlayer(IHAAMHPPLMG player_id)
	{
	}

	[Token(Token = "0x600CA6F")]
	[Address(RVA = "0x18854C4", Offset = "0x18854C4", VA = "0x18854C4")]
	private void onAddBtnClicked()
	{
	}

	[Token(Token = "0x600CA70")]
	[Address(RVA = "0x18856DC", Offset = "0x18856DC", VA = "0x18856DC")]
	private void _003CBindPlayer_003Em__0()
	{
	}

	[Token(Token = "0x600CA71")]
	[Address(RVA = "0x1885700", Offset = "0x1885700", VA = "0x1885700")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
