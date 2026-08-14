using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024D4")]
public class UIAvatarSkillSlotController : UIBaseController
{
	[Token(Token = "0x400E457")]
	[FieldOffset(Offset = "0x28")]
	private uint m_AvatarID;

	[Token(Token = "0x400E458")]
	[FieldOffset(Offset = "0x2C")]
	private int m_SlotIndex;

	[Token(Token = "0x400E459")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsLocked;

	[Token(Token = "0x400E45A")]
	[FieldOffset(Offset = "0x31")]
	private bool m_IsEquip;

	[Token(Token = "0x400E45B")]
	[FieldOffset(Offset = "0x32")]
	private bool canUnLock;

	[Token(Token = "0x400E45C")]
	[FieldOffset(Offset = "0x34")]
	private UIAvatarSkillSlotView m_View;

	[Token(Token = "0x400E45D")]
	[FieldOffset(Offset = "0x38")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400E45E")]
	[FieldOffset(Offset = "0x3C")]
	private AvatarProfile avatarProfile;

	[Token(Token = "0x400E45F")]
	private const string m_FixedSkillTipKey = "TXT_PROFILE_FIXEDSKILL_TIP";

	[Token(Token = "0x400E460")]
	private const string m_UnLockPreSlotTipKey = "TXT_OB8_JRW_NEED_TO_UNLOCK_PRESLOT_TIP";

	[Token(Token = "0x400E461")]
	private const string m_OpenNewSlotTipKey = "OPEN_NEW_SLOT_TIP";

	[Token(Token = "0x400E462")]
	[FieldOffset(Offset = "0x40")]
	private uint m_DelayCallID;

	[Token(Token = "0x400E463")]
	[FieldOffset(Offset = "0x44")]
	private AvatarSkillData m_Skilldata;

	[Token(Token = "0x400E464")]
	[FieldOffset(Offset = "0x48")]
	private UICommonGuideController m_guideCtrl;

	[Token(Token = "0x17001136")]
	public bool IsLocked
	{
		[Token(Token = "0x600D3E7")]
		[Address(RVA = "0x2F9A31C", Offset = "0x2F9A31C", VA = "0x2F9A31C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600D3E6")]
	[Address(RVA = "0x2F9A298", Offset = "0x2F9A298", VA = "0x2F9A298")]
	public UIAvatarSkillSlotController()
	{
	}

	[Token(Token = "0x600D3E8")]
	[Address(RVA = "0x2F9A374", Offset = "0x2F9A374", VA = "0x2F9A374", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D3E9")]
	[Address(RVA = "0x2F9A7AC", Offset = "0x2F9A7AC", VA = "0x2F9A7AC")]
	public void SetShowSpeicialGo(bool flag)
	{
	}

	[Token(Token = "0x600D3EA")]
	[Address(RVA = "0x2F9A844", Offset = "0x2F9A844", VA = "0x2F9A844", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D3EB")]
	[Address(RVA = "0x2F9AB18", Offset = "0x2F9AB18", VA = "0x2F9AB18")]
	public void SetSpeicalLvBg()
	{
	}

	[Token(Token = "0x600D3EC")]
	[Address(RVA = "0x2F972DC", Offset = "0x2F972DC", VA = "0x2F972DC")]
	public void HideAllLvbg()
	{
	}

	[Token(Token = "0x600D3ED")]
	[Address(RVA = "0x2F98550", Offset = "0x2F98550", VA = "0x2F98550")]
	public void SetThirdLvBg()
	{
	}

	[Token(Token = "0x600D3EE")]
	[Address(RVA = "0x2F9ACB4", Offset = "0x2F9ACB4", VA = "0x2F9ACB4")]
	public void SetSkillVFX(bool state)
	{
	}

	[Token(Token = "0x600D3EF")]
	[Address(RVA = "0x2F976E0", Offset = "0x2F976E0", VA = "0x2F976E0")]
	public void SetData(uint skillID, int slotindex, bool isLocked, uint avatarid, bool isUnReachLv = false)
	{
	}

	[Token(Token = "0x600D3F0")]
	[Address(RVA = "0x2F9B0B4", Offset = "0x2F9B0B4", VA = "0x2F9B0B4")]
	public void SetSkillLevelSpecially(uint skillID)
	{
	}

	[Token(Token = "0x600D3F1")]
	[Address(RVA = "0x2F9B2E0", Offset = "0x2F9B2E0", VA = "0x2F9B2E0")]
	private void OnUpdateRedTips(object[] data)
	{
	}

	[Token(Token = "0x600D3F2")]
	[Address(RVA = "0x2F9AFE4", Offset = "0x2F9AFE4", VA = "0x2F9AFE4")]
	private bool CheckHasTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D3F3")]
	[Address(RVA = "0x2F9B4D4", Offset = "0x2F9B4D4", VA = "0x2F9B4D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D3F4")]
	[Address(RVA = "0x2F9AD4C", Offset = "0x2F9AD4C", VA = "0x2F9AD4C")]
	private void SetBgColor(char type)
	{
	}

	[Token(Token = "0x600D3F5")]
	[Address(RVA = "0x2F9B578", Offset = "0x2F9B578", VA = "0x2F9B578")]
	private void OnSlotClick()
	{
	}

	[Token(Token = "0x600D3F6")]
	[Address(RVA = "0x2F9C198", Offset = "0x2F9C198", VA = "0x2F9C198")]
	private void OnSkillWindowClose(object[] data)
	{
	}

	[Token(Token = "0x600D3F7")]
	[Address(RVA = "0x2F9C2F0", Offset = "0x2F9C2F0", VA = "0x2F9C2F0")]
	private void OnUnlockSkillSlot(object[] data)
	{
	}

	[Token(Token = "0x600D3F8")]
	[Address(RVA = "0x2F9C714", Offset = "0x2F9C714", VA = "0x2F9C714")]
	public void ClearDelayCall()
	{
	}

	[Token(Token = "0x600D3F9")]
	[Address(RVA = "0x2F98460", Offset = "0x2F98460", VA = "0x2F98460")]
	public void DisableSlotBtn()
	{
	}

	[Token(Token = "0x600D3FA")]
	[Address(RVA = "0x2F9C824", Offset = "0x2F9C824", VA = "0x2F9C824")]
	public void OnWindowCover(object[] data)
	{
	}

	[Token(Token = "0x600D3FB")]
	[Address(RVA = "0x2F9CB84", Offset = "0x2F9CB84", VA = "0x2F9CB84")]
	public List<int> GetSlotBtnSize()
	{
		return null;
	}

	[Token(Token = "0x600D3FC")]
	[Address(RVA = "0x2F9CD6C", Offset = "0x2F9CD6C", VA = "0x2F9CD6C")]
	public List<EventDelegate> GetSlotBtnCallback()
	{
		return null;
	}

	[Token(Token = "0x600D3FD")]
	[Address(RVA = "0x2F9CDF0", Offset = "0x2F9CDF0", VA = "0x2F9CDF0")]
	public void SetFreeUnlockView(bool show)
	{
	}

	[Token(Token = "0x600D3FE")]
	[Address(RVA = "0x2F9CE88", Offset = "0x2F9CE88", VA = "0x2F9CE88")]
	private void _003COnUnlockSkillSlot_003Em__0()
	{
	}

	[Token(Token = "0x600D3FF")]
	[Address(RVA = "0x2F9D038", Offset = "0x2F9D038", VA = "0x2F9D038")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D400")]
	[Address(RVA = "0x2F9D040", Offset = "0x2F9D040", VA = "0x2F9D040")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
