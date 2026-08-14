using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A98")]
public class UIAvatarSkillSlotMono : MonoBehaviour
{
	[Token(Token = "0x4018EA3")]
	[FieldOffset(Offset = "0xC")]
	private uint m_AvatarID;

	[Token(Token = "0x4018EA4")]
	[FieldOffset(Offset = "0x10")]
	private int m_SlotIndex;

	[Token(Token = "0x4018EA5")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsLocked;

	[Token(Token = "0x4018EA6")]
	[FieldOffset(Offset = "0x15")]
	private bool m_IsEquip;

	[Token(Token = "0x4018EA7")]
	[FieldOffset(Offset = "0x16")]
	private bool canUnLock;

	[Token(Token = "0x4018EA8")]
	[FieldOffset(Offset = "0x18")]
	public AvatarSelectionSkillSlot SlotScript;

	[Token(Token = "0x4018EA9")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton SlotBtn;

	[Token(Token = "0x4018EAA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SelectedHL;

	[Token(Token = "0x4018EAB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NormalBG_G;

	[Token(Token = "0x4018EAC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NormalBG_Y;

	[Token(Token = "0x4018EAD")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NormalBG_R;

	[Token(Token = "0x4018EAE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject NormalBG_N;

	[Token(Token = "0x4018EAF")]
	[FieldOffset(Offset = "0x34")]
	public GameObject lv_bg;

	[Token(Token = "0x4018EB0")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LvLabel;

	[Token(Token = "0x4018EB1")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject lv_bg2;

	[Token(Token = "0x4018EB2")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LvLabel2;

	[Token(Token = "0x4018EB3")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Empty;

	[Token(Token = "0x4018EB4")]
	[FieldOffset(Offset = "0x48")]
	public GameObject LockGo;

	[Token(Token = "0x4018EB5")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject lockSprite;

	[Token(Token = "0x4018EB6")]
	[FieldOffset(Offset = "0x50")]
	public GameObject unlockAnim;

	[Token(Token = "0x4018EB7")]
	[FieldOffset(Offset = "0x54")]
	public GameObject newSlotTip;

	[Token(Token = "0x4018EB8")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ActiveSkillLock;

	[Token(Token = "0x4018EB9")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject RedTips;

	[Token(Token = "0x4018EBA")]
	[FieldOffset(Offset = "0x60")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x4018EBB")]
	[FieldOffset(Offset = "0x64")]
	private AvatarProfile avatarProfile;

	[Token(Token = "0x4018EBC")]
	private const string m_FixedSkillTipKey = "TXT_PROFILE_FIXEDSKILL_TIP";

	[Token(Token = "0x4018EBD")]
	private const string m_UnLockPreSlotTipKey = "TXT_OB8_JRW_NEED_TO_UNLOCK_PRESLOT_TIP";

	[Token(Token = "0x4018EBE")]
	private const string m_OpenNewSlotTipKey = "OPEN_NEW_SLOT_TIP";

	[Token(Token = "0x4018EBF")]
	[FieldOffset(Offset = "0x68")]
	private uint m_DelayCallID;

	[Token(Token = "0x4018EC0")]
	[FieldOffset(Offset = "0x6C")]
	private AvatarSkillData m_Skilldata;

	[Token(Token = "0x6017378")]
	[Address(RVA = "0x2F9D048", Offset = "0x2F9D048", VA = "0x2F9D048")]
	public UIAvatarSkillSlotMono()
	{
	}

	[Token(Token = "0x6017379")]
	[Address(RVA = "0x2F9D050", Offset = "0x2F9D050", VA = "0x2F9D050")]
	protected void Awake()
	{
	}

	[Token(Token = "0x601737A")]
	[Address(RVA = "0x2F9D388", Offset = "0x2F9D388", VA = "0x2F9D388")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x601737B")]
	[Address(RVA = "0x2F9D650", Offset = "0x2F9D650", VA = "0x2F9D650")]
	public void SetData(uint skillID, int slotindex, bool isLocked, uint avatarid, bool isUnReachLv = false)
	{
	}

	[Token(Token = "0x601737C")]
	[Address(RVA = "0x2F9E29C", Offset = "0x2F9E29C", VA = "0x2F9E29C")]
	private void OnUpdateRedTips(object[] data)
	{
	}

	[Token(Token = "0x601737D")]
	[Address(RVA = "0x2F9E1CC", Offset = "0x2F9E1CC", VA = "0x2F9E1CC")]
	private bool CheckHasTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x601737E")]
	[Address(RVA = "0x2F9DFD4", Offset = "0x2F9DFD4", VA = "0x2F9DFD4")]
	private void SetBgColor(char type)
	{
	}

	[Token(Token = "0x601737F")]
	[Address(RVA = "0x2F9E464", Offset = "0x2F9E464", VA = "0x2F9E464")]
	private void OnSkillWindowClose(object[] data)
	{
	}

	[Token(Token = "0x6017380")]
	[Address(RVA = "0x2F9E594", Offset = "0x2F9E594", VA = "0x2F9E594")]
	private void OnUnlockSkillSlot(object[] data)
	{
	}

	[Token(Token = "0x6017381")]
	[Address(RVA = "0x2F9E7C4", Offset = "0x2F9E7C4", VA = "0x2F9E7C4")]
	public void DisableSlotBtn()
	{
	}

	[Token(Token = "0x6017382")]
	[Address(RVA = "0x2F9E88C", Offset = "0x2F9E88C", VA = "0x2F9E88C")]
	public void HideAllLvBg()
	{
	}

	[Token(Token = "0x6017383")]
	[Address(RVA = "0x2F9E92C", Offset = "0x2F9E92C", VA = "0x2F9E92C")]
	public void OnWindowCover(object[] data)
	{
	}
}
