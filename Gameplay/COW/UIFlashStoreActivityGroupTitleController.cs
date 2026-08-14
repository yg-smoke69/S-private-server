using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20020F2")]
public class UIFlashStoreActivityGroupTitleController : UIBaseController
{
	[Token(Token = "0x400CDF7")]
	[FieldOffset(Offset = "0x28")]
	private uint m_FlashStoreActivityID;

	[Token(Token = "0x400CDF8")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_ActivityGroupID;

	[Token(Token = "0x400CDF9")]
	[FieldOffset(Offset = "0x30")]
	private EActivity.ActivityType m_ActivityType;

	[Token(Token = "0x400CDFA")]
	[FieldOffset(Offset = "0x34")]
	private UIFlashStoreActivityGroupTitleView m_View;

	[Token(Token = "0x600AAB8")]
	[Address(RVA = "0x1DC29C4", Offset = "0x1DC29C4", VA = "0x1DC29C4")]
	public UIFlashStoreActivityGroupTitleController()
	{
	}

	[Token(Token = "0x600AAB9")]
	[Address(RVA = "0x1DC2A48", Offset = "0x1DC2A48", VA = "0x1DC2A48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AABA")]
	[Address(RVA = "0x1DC2AF0", Offset = "0x1DC2AF0", VA = "0x1DC2AF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AABB")]
	[Address(RVA = "0x1DC2BB4", Offset = "0x1DC2BB4", VA = "0x1DC2BB4")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x600AABC")]
	[Address(RVA = "0x1DC2CE8", Offset = "0x1DC2CE8", VA = "0x1DC2CE8")]
	private static bool IsCountdownNeeded(EActivity.ActivityType activityType)
	{
		return default(bool);
	}

	[Token(Token = "0x600AABD")]
	[Address(RVA = "0x1DC2D54", Offset = "0x1DC2D54", VA = "0x1DC2D54")]
	private ulong GetCountdownTargetTime()
	{
		return default(ulong);
	}

	[Token(Token = "0x600AABE")]
	[Address(RVA = "0x1DC2F18", Offset = "0x1DC2F18", VA = "0x1DC2F18")]
	private static string GetActivityTypeTitleKey(EActivity.ActivityType activityType)
	{
		return null;
	}

	[Token(Token = "0x600AABF")]
	[Address(RVA = "0x1DC30E0", Offset = "0x1DC30E0", VA = "0x1DC30E0")]
	private void RefreshCountdown()
	{
	}

	[Token(Token = "0x600AAC0")]
	[Address(RVA = "0x1DC33FC", Offset = "0x1DC33FC", VA = "0x1DC33FC")]
	public UIFlashStoreActivityGroupTitleController SetViewData(uint activityType, uint flashStoreActivityID, uint activityGroupID)
	{
		return null;
	}

	[Token(Token = "0x600AAC1")]
	[Address(RVA = "0x1DC3598", Offset = "0x1DC3598", VA = "0x1DC3598")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
