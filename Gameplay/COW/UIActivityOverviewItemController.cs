using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F6A")]
public class UIActivityOverviewItemController : UIBaseController
{
	[Token(Token = "0x2001F6B")]
	public enum EActivityState
	{
		[Token(Token = "0x400C558")]
		Coming,
		[Token(Token = "0x400C559")]
		Normal,
		[Token(Token = "0x400C55A")]
		Expired
	}

	[Token(Token = "0x400C54F")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityOverviewItemView m_View;

	[Token(Token = "0x400C550")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C551")]
	[FieldOffset(Offset = "0x30")]
	private AdvertDesc m_Data;

	[Token(Token = "0x400C552")]
	[FieldOffset(Offset = "0x34")]
	private ClientActivityDesc m_OverViewDesc;

	[Token(Token = "0x400C553")]
	private const string COMING_STRING = "TXT_OB8_GXQ_EVENT_NOTSTARTED";

	[Token(Token = "0x400C554")]
	private const string ACTIVE_STRING = "TXT_LOBBY_EVENT_GOTO";

	[Token(Token = "0x400C555")]
	private const string EXPIRED_STRING = "TXT_OB9_GXQ_GIFTMALL_TIMEOUT";

	[Token(Token = "0x400C556")]
	[FieldOffset(Offset = "0x38")]
	private EActivityState m_ActivityState;

	[Token(Token = "0x6009BB2")]
	[Address(RVA = "0x2FBA5FC", Offset = "0x2FBA5FC", VA = "0x2FBA5FC")]
	public UIActivityOverviewItemController()
	{
	}

	[Token(Token = "0x6009BB3")]
	[Address(RVA = "0x2FBA680", Offset = "0x2FBA680", VA = "0x2FBA680")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009BB4")]
	[Address(RVA = "0x2FBA724", Offset = "0x2FBA724", VA = "0x2FBA724", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009BB5")]
	[Address(RVA = "0x2FBA23C", Offset = "0x2FBA23C", VA = "0x2FBA23C")]
	public void SetData(AdvertDesc data)
	{
	}

	[Token(Token = "0x6009BB6")]
	[Address(RVA = "0x2FBAA0C", Offset = "0x2FBAA0C", VA = "0x2FBAA0C")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6009BB7")]
	[Address(RVA = "0x2FBB29C", Offset = "0x2FBB29C", VA = "0x2FBB29C")]
	private void OnGoToClick()
	{
	}

	[Token(Token = "0x6009BB8")]
	[Address(RVA = "0x2FBB69C", Offset = "0x2FBB69C", VA = "0x2FBB69C")]
	private void SendBannerClickLog(uint id)
	{
	}

	[Token(Token = "0x6009BB9")]
	[Address(RVA = "0x2FBA544", Offset = "0x2FBA544", VA = "0x2FBA544")]
	public void Reload()
	{
	}

	[Token(Token = "0x6009BBA")]
	[Address(RVA = "0x2FBB8A8", Offset = "0x2FBB8A8", VA = "0x2FBB8A8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
