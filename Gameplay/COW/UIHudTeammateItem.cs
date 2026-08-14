using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002D43")]
internal class UIHudTeammateItem : MonoBehaviour
{
	[Token(Token = "0x40114F3")]
	protected const int KNOCK_INFO_WEAPON_OFFSET = 20;

	[Token(Token = "0x40114F4")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Name;

	[Token(Token = "0x40114F5")]
	[FieldOffset(Offset = "0x10")]
	public GameObject HPBarGO;

	[Token(Token = "0x40114F6")]
	[FieldOffset(Offset = "0x14")]
	public UISprite HPSprite;

	[Token(Token = "0x40114F7")]
	[FieldOffset(Offset = "0x18")]
	public UIProgressBar HPProgressBar;

	[Token(Token = "0x40114F8")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Mark;

	[Token(Token = "0x40114F9")]
	[FieldOffset(Offset = "0x20")]
	public UIHudPlayerMarkIcon PlayerMark;

	[Token(Token = "0x40114FA")]
	[FieldOffset(Offset = "0x24")]
	public GameObject KillerGO;

	[Token(Token = "0x40114FB")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TeamIndex;

	[Token(Token = "0x40114FC")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Knockdown;

	[Token(Token = "0x40114FD")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Offline;

	[Token(Token = "0x40114FE")]
	[FieldOffset(Offset = "0x34")]
	public UISprite DisFlag;

	[Token(Token = "0x40114FF")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Vehicle;

	[Token(Token = "0x4011500")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject VoiceGO;

	[Token(Token = "0x4011501")]
	[FieldOffset(Offset = "0x40")]
	public GameObject QuickMsgGO;

	[Token(Token = "0x4011502")]
	[FieldOffset(Offset = "0x44")]
	public GameObject MutedGO;

	[Token(Token = "0x4011503")]
	[FieldOffset(Offset = "0x48")]
	public UISprite TeamParachuteIcon;

	[Token(Token = "0x4011504")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ModeRelatedContainer;

	[Token(Token = "0x4011505")]
	[FieldOffset(Offset = "0x50")]
	public UISprite ModeIcon;

	[Token(Token = "0x4011506")]
	[FieldOffset(Offset = "0x54")]
	public UILabel ModeTxt;

	[Token(Token = "0x4011507")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ModeVFXEffect;

	[Token(Token = "0x4011508")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject Effect_Glow;

	[Token(Token = "0x4011509")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid m_CelebrityGrid;

	[Token(Token = "0x401150A")]
	[FieldOffset(Offset = "0x64")]
	public UISprite TrainingZoneIcon;

	[Token(Token = "0x401150B")]
	[FieldOffset(Offset = "0x68")]
	public UISprite HeadBGSprite;

	[Token(Token = "0x401150C")]
	[FieldOffset(Offset = "0x6C")]
	public Transform NameTextAnchor;

	[Token(Token = "0x401150D")]
	[FieldOffset(Offset = "0x70")]
	public UIGrid IconGrid;

	[Token(Token = "0x401150E")]
	[FieldOffset(Offset = "0x74")]
	public GameObject WantedIcon;

	[Token(Token = "0x401150F")]
	[FieldOffset(Offset = "0x78")]
	public UILabel Level;

	[Token(Token = "0x4011510")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject HealGunLiveEffect;

	[Token(Token = "0x4011511")]
	[FieldOffset(Offset = "0x80")]
	public GameObject VFF_Rescue;

	[Token(Token = "0x4011512")]
	[FieldOffset(Offset = "0x84")]
	public UIWidget GridLastPos;

	[Token(Token = "0x4011513")]
	[FieldOffset(Offset = "0x88")]
	public GameObject KnockInfo;

	[Token(Token = "0x4011514")]
	[FieldOffset(Offset = "0x8C")]
	public UISprite KnockInfoWeapon;

	[Token(Token = "0x4011515")]
	[FieldOffset(Offset = "0x90")]
	public UISprite KnockInfoResult;

	[Token(Token = "0x4011516")]
	[FieldOffset(Offset = "0x94")]
	public GameObject BuySelfReviveVfx;

	[Token(Token = "0x4011517")]
	[FieldOffset(Offset = "0x98")]
	public int TeamIndexNum;

	[Token(Token = "0x4011518")]
	[FieldOffset(Offset = "0xA0")]
	public IHAAMHPPLMG pID;

	[Token(Token = "0x4011519")]
	[FieldOffset(Offset = "0xB8")]
	private ETeammateState m_CurrentState;

	[Token(Token = "0x401151A")]
	[FieldOffset(Offset = "0xBC")]
	private UITimeLabelHelper m_CountDownLabel;

	[Token(Token = "0x401151B")]
	[FieldOffset(Offset = "0xC0")]
	private BitArrayBoolean ModeRelatedContainerShow;

	[Token(Token = "0x401151C")]
	private const uint ADS1v1CountDown = 1u;

	[Token(Token = "0x401151D")]
	private const uint ADS1v1BonusCountDown = 2u;

	[Token(Token = "0x401151E")]
	[FieldOffset(Offset = "0xC4")]
	private uint m_QuickMsgDelayHideID;

	[Token(Token = "0x401151F")]
	[FieldOffset(Offset = "0xC8")]
	private uint m_KnockDownIconDelayID;

	[Token(Token = "0x4011520")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_IsMute;

	[Token(Token = "0x4011521")]
	[FieldOffset(Offset = "0xD0")]
	private readonly Color NAME_COLOR_SELF;

	[Token(Token = "0x4011522")]
	[FieldOffset(Offset = "0xE0")]
	private readonly Color NAME_COLOR_NORMAL;

	[Token(Token = "0x4011523")]
	[FieldOffset(Offset = "0xF0")]
	private readonly Color NAME_COLOR_DEAD;

	[Token(Token = "0x4011524")]
	[FieldOffset(Offset = "0x100")]
	private bool healHintEffectShow;

	[Token(Token = "0x17001369")]
	public ETeammateState CurrentState
	{
		[Token(Token = "0x6012F02")]
		[Address(RVA = "0x179D638", Offset = "0x179D638", VA = "0x179D638")]
		get
		{
			return default(ETeammateState);
		}
	}

	[Token(Token = "0x6012F01")]
	[Address(RVA = "0x179D4EC", Offset = "0x179D4EC", VA = "0x179D4EC")]
	public UIHudTeammateItem()
	{
	}

	[Token(Token = "0x6012F03")]
	[Address(RVA = "0x179D690", Offset = "0x179D690", VA = "0x179D690")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012F04")]
	[Address(RVA = "0x179D9C8", Offset = "0x179D9C8", VA = "0x179D9C8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6012F05")]
	[Address(RVA = "0x179DC28", Offset = "0x179DC28", VA = "0x179DC28")]
	private void OnRecvQuickChat(object[] data)
	{
	}

	[Token(Token = "0x6012F06")]
	[Address(RVA = "0x179E1F0", Offset = "0x179E1F0", VA = "0x179E1F0")]
	public void Show(bool v)
	{
	}

	[Token(Token = "0x6012F07")]
	[Address(RVA = "0x179E280", Offset = "0x179E280", VA = "0x179E280")]
	private void OnGridReposition()
	{
	}

	[Token(Token = "0x6012F08")]
	[Address(RVA = "0x179E37C", Offset = "0x179E37C", VA = "0x179E37C")]
	private void UpdateCelebrity(uint role)
	{
	}

	[Token(Token = "0x6012F09")]
	[Address(RVA = "0x179E664", Offset = "0x179E664", VA = "0x179E664", Slot = "4")]
	public virtual void InitInfo(Player p)
	{
	}

	[Token(Token = "0x6012F0A")]
	[Address(RVA = "0x179F09C", Offset = "0x179F09C", VA = "0x179F09C")]
	private void SetPlayerIndexInfo(int playerIndex)
	{
	}

	[Token(Token = "0x6012F0B")]
	[Address(RVA = "0x179F988", Offset = "0x179F988", VA = "0x179F988", Slot = "5")]
	public virtual void InitInfo(MatchTeam.MNJIFKDNEKI p)
	{
	}

	[Token(Token = "0x6012F0C")]
	[Address(RVA = "0x17A0020", Offset = "0x17A0020", VA = "0x17A0020")]
	public void OnKnockDownStateChanged(bool isDown, float ratio)
	{
	}

	[Token(Token = "0x6012F0D")]
	[Address(RVA = "0x17A0144", Offset = "0x17A0144", VA = "0x17A0144", Slot = "6")]
	public virtual void InitWithPlayerInfo(MNJIFKDNEKI playerInfo)
	{
	}

	[Token(Token = "0x6012F0E")]
	[Address(RVA = "0x179E14C", Offset = "0x179E14C", VA = "0x179E14C")]
	public void ShowQuickMsg()
	{
	}

	[Token(Token = "0x6012F0F")]
	[Address(RVA = "0x17A078C", Offset = "0x17A078C", VA = "0x17A078C")]
	public void HideQuickMsg()
	{
	}

	[Token(Token = "0x6012F10")]
	[Address(RVA = "0x179F3E8", Offset = "0x179F3E8", VA = "0x179F3E8")]
	public void SetVoiceVisible(bool flag)
	{
	}

	[Token(Token = "0x6012F11")]
	[Address(RVA = "0x179F358", Offset = "0x179F358", VA = "0x179F358")]
	public void SetMuteVisible(bool is_mute)
	{
	}

	[Token(Token = "0x6012F12")]
	[Address(RVA = "0x17A0808", Offset = "0x17A0808", VA = "0x17A0808", Slot = "7")]
	public virtual void SetReviveInfo()
	{
	}

	[Token(Token = "0x6012F13")]
	[Address(RVA = "0x179F8D0", Offset = "0x179F8D0", VA = "0x179F8D0")]
	public void SetMarkShow(bool show)
	{
	}

	[Token(Token = "0x6012F14")]
	[Address(RVA = "0x179F588", Offset = "0x179F588", VA = "0x179F588")]
	public void SetTeammateState(ETeammateState nextState)
	{
	}

	[Token(Token = "0x6012F15")]
	[Address(RVA = "0x179F21C", Offset = "0x179F21C", VA = "0x179F21C")]
	public void SetDisconnected(bool disconnected)
	{
	}

	[Token(Token = "0x6012F16")]
	[Address(RVA = "0x17A0AEC", Offset = "0x17A0AEC", VA = "0x17A0AEC", Slot = "8")]
	public virtual void OnHPChanged(Player p)
	{
	}

	[Token(Token = "0x6012F17")]
	[Address(RVA = "0x17A1114", Offset = "0x17A1114", VA = "0x17A1114", Slot = "9")]
	protected virtual void InitModeRelatedInfo(Player p)
	{
	}

	[Token(Token = "0x6012F18")]
	[Address(RVA = "0x17A0608", Offset = "0x17A0608", VA = "0x17A0608")]
	private void InitModeRelatedInfo(MNJIFKDNEKI p)
	{
	}

	[Token(Token = "0x6012F19")]
	[Address(RVA = "0x179FEC8", Offset = "0x179FEC8", VA = "0x179FEC8")]
	private void InitModeRelatedInfo(MatchTeam.MNJIFKDNEKI p)
	{
	}

	[Token(Token = "0x6012F1A")]
	[Address(RVA = "0x17A1ED8", Offset = "0x17A1ED8", VA = "0x17A1ED8")]
	public void UpdateModeRelatedInfo(byte num)
	{
	}

	[Token(Token = "0x6012F1B")]
	[Address(RVA = "0x17A1C2C", Offset = "0x17A1C2C", VA = "0x17A1C2C")]
	public void UpdateTrainingZoneIcon(byte val)
	{
	}

	[Token(Token = "0x6012F1C")]
	[Address(RVA = "0x17A085C", Offset = "0x17A085C", VA = "0x17A085C")]
	public void UpdateBombModeBomb()
	{
	}

	[Token(Token = "0x6012F1D")]
	[Address(RVA = "0x17A215C", Offset = "0x17A215C", VA = "0x17A215C")]
	public void UpdateADSMode1v1Info(object[] data)
	{
	}

	[Token(Token = "0x6012F1E")]
	[Address(RVA = "0x17A2578", Offset = "0x17A2578", VA = "0x17A2578")]
	public void ShowADS1v1Winner(bool show)
	{
	}

	[Token(Token = "0x6012F1F")]
	[Address(RVA = "0x17A2794", Offset = "0x17A2794", VA = "0x17A2794")]
	public void ShowModeRelatedEffect(bool show)
	{
	}

	[Token(Token = "0x6012F20")]
	[Address(RVA = "0x17A2818", Offset = "0x17A2818", VA = "0x17A2818")]
	public void Update()
	{
	}

	[Token(Token = "0x6012F21")]
	[Address(RVA = "0x17A29DC", Offset = "0x17A29DC", VA = "0x17A29DC")]
	private void OnWantedIconShow(object[] data)
	{
	}

	[Token(Token = "0x6012F22")]
	[Address(RVA = "0x17A2BF4", Offset = "0x17A2BF4", VA = "0x17A2BF4")]
	public void OnLocalPlayerChangeWeapon(bool isHealGun)
	{
	}

	[Token(Token = "0x6012F23")]
	[Address(RVA = "0x17A2F40", Offset = "0x17A2F40", VA = "0x17A2F40")]
	private void StartHealHintEffect()
	{
	}

	[Token(Token = "0x6012F24")]
	[Address(RVA = "0x17A3118", Offset = "0x17A3118", VA = "0x17A3118")]
	private void StopHealHintEffect()
	{
	}

	[Token(Token = "0x6012F25")]
	[Address(RVA = "0x17A2D6C", Offset = "0x17A2D6C", VA = "0x17A2D6C")]
	private bool CheckHpNeedShowHealHint(Player p)
	{
		return default(bool);
	}

	[Token(Token = "0x6012F26")]
	[Address(RVA = "0x17A0F00", Offset = "0x17A0F00", VA = "0x17A0F00")]
	private void CheckHealHintOnHpChange(Player p)
	{
	}

	[Token(Token = "0x6012F27")]
	[Address(RVA = "0x17A32F0", Offset = "0x17A32F0", VA = "0x17A32F0", Slot = "10")]
	public virtual void OnLevelChanged(Player p)
	{
	}

	[Token(Token = "0x6012F28")]
	[Address(RVA = "0x17A34E8", Offset = "0x17A34E8", VA = "0x17A34E8")]
	public void OnRescue()
	{
	}

	[Token(Token = "0x6012F29")]
	[Address(RVA = "0x17A3588", Offset = "0x17A3588", VA = "0x17A3588", Slot = "11")]
	public virtual void RepositionKnockInfo()
	{
	}

	[Token(Token = "0x6012F2A")]
	[Address(RVA = "0x17A3BE0", Offset = "0x17A3BE0", VA = "0x17A3BE0")]
	public void OnCanBuySelfRevive(object[] data)
	{
	}

	[Token(Token = "0x6012F2B")]
	[Address(RVA = "0x17A3C64", Offset = "0x17A3C64", VA = "0x17A3C64")]
	public void OnKnockDownAndKill(object[] data)
	{
	}

	[Token(Token = "0x6012F2C")]
	[Address(RVA = "0x17A42A4", Offset = "0x17A42A4", VA = "0x17A42A4")]
	private void _003COnKnockDownAndKill_003Em__0()
	{
	}
}
