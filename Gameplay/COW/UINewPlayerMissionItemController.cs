using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002278")]
public class UINewPlayerMissionItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400D7D5")]
	[FieldOffset(Offset = "0x28")]
	private UINewPlayerMissionItemView m_View;

	[Token(Token = "0x400D7D6")]
	private const string ENTER_ANIM_NAME = "UINewPlayerMissionItem_In";

	[Token(Token = "0x400D7D7")]
	private const string CLAIM_ANIM_NAME = "UINewPlayerMissionItem_Receive";

	[Token(Token = "0x400D7D8")]
	[FieldOffset(Offset = "0x2C")]
	private EActivity.State m_MissionStatus;

	[Token(Token = "0x400D7D9")]
	[FieldOffset(Offset = "0x30")]
	private uint m_MissionId;

	[Token(Token = "0x400D7DA")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsLocked;

	[Token(Token = "0x400D7DB")]
	[FieldOffset(Offset = "0x38")]
	private ENewbieGuideType m_GotoGuideId;

	[Token(Token = "0x400D7DC")]
	[FieldOffset(Offset = "0x3C")]
	private UIStandardItemMiniController m_Reward;

	[Token(Token = "0x600BCF3")]
	[Address(RVA = "0x27AAB24", Offset = "0x27AAB24", VA = "0x27AAB24")]
	public UINewPlayerMissionItemController()
	{
	}

	[Token(Token = "0x600BCF4")]
	[Address(RVA = "0x27AABB0", Offset = "0x27AABB0", VA = "0x27AABB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BCF5")]
	[Address(RVA = "0x27AAC58", Offset = "0x27AAC58", VA = "0x27AAC58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BCF6")]
	[Address(RVA = "0x27A70E0", Offset = "0x27A70E0", VA = "0x27A70E0")]
	public void SetViewData(uint achievementId, bool isLocked, uint curDay = 1u)
	{
	}

	[Token(Token = "0x600BCF7")]
	[Address(RVA = "0x27AAF00", Offset = "0x27AAF00", VA = "0x27AAF00")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600BCF8")]
	[Address(RVA = "0x27ABAF0", Offset = "0x27ABAF0", VA = "0x27ABAF0")]
	private void OnMissionRewardButtonClick()
	{
	}

	[Token(Token = "0x600BCF9")]
	[Address(RVA = "0x27AC4B0", Offset = "0x27AC4B0", VA = "0x27AC4B0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BCFA")]
	[Address(RVA = "0x27AC93C", Offset = "0x27AC93C", VA = "0x27AC93C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BCFB")]
	[Address(RVA = "0x27AC9D0", Offset = "0x27AC9D0", VA = "0x27AC9D0")]
	private void PlayEnterAnimation()
	{
	}

	[Token(Token = "0x600BCFC")]
	[Address(RVA = "0x27AC864", Offset = "0x27AC864", VA = "0x27AC864")]
	private void PlayClaimAnimation()
	{
	}

	[Token(Token = "0x600BCFD")]
	[Address(RVA = "0x27ACAA8", Offset = "0x27ACAA8", VA = "0x27ACAA8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
