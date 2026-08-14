using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002805")]
internal class UIHudPlayerStatsController : UIBaseController
{
	[Token(Token = "0x2002806")]
	private enum ELongPressType
	{
		[Token(Token = "0x400F72A")]
		exp = 1,
		[Token(Token = "0x400F72B")]
		level,
		[Token(Token = "0x400F72C")]
		weaponDamageRate
	}

	[Token(Token = "0x2002807")]
	private sealed class _003COnSkillSpecialAnim_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F72D")]
		[FieldOffset(Offset = "0x8")]
		internal string skillType;

		[Token(Token = "0x600F934")]
		[Address(RVA = "0x1FB7F40", Offset = "0x1FB7F40", VA = "0x1FB7F40")]
		public _003COnSkillSpecialAnim_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600F935")]
		[Address(RVA = "0x1FB7F48", Offset = "0x1FB7F48", VA = "0x1FB7F48")]
		internal bool _003C_003Em__0(UIHudSkillTemplateController i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002808")]
	private sealed class _003COnPetSkillCoolDownAnim_003Ec__AnonStorey1
	{
		[Token(Token = "0x400F72E")]
		[FieldOffset(Offset = "0x8")]
		internal string skillType;

		[Token(Token = "0x600F936")]
		[Address(RVA = "0x1FB7DE8", Offset = "0x1FB7DE8", VA = "0x1FB7DE8")]
		public _003COnPetSkillCoolDownAnim_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600F937")]
		[Address(RVA = "0x1FB7DF0", Offset = "0x1FB7DF0", VA = "0x1FB7DF0")]
		internal bool _003C_003Em__0(UIHudSkillTemplateController i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002809")]
	private sealed class _003COnPetSkillCoolDownSPEAnim_003Ec__AnonStorey2
	{
		[Token(Token = "0x400F72F")]
		[FieldOffset(Offset = "0x8")]
		internal string skillType;

		[Token(Token = "0x600F938")]
		[Address(RVA = "0x1FB7E94", Offset = "0x1FB7E94", VA = "0x1FB7E94")]
		public _003COnPetSkillCoolDownSPEAnim_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600F939")]
		[Address(RVA = "0x1FB7E9C", Offset = "0x1FB7E9C", VA = "0x1FB7E9C")]
		internal bool _003C_003Em__0(UIHudSkillTemplateController i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200280A")]
	private sealed class _003CAddPetSkillByPetSkillData_003Ec__AnonStorey3
	{
		[Token(Token = "0x400F730")]
		[FieldOffset(Offset = "0x8")]
		internal PetSkillLevelData petSkillData;

		[Token(Token = "0x600F93A")]
		[Address(RVA = "0x1FB7AD4", Offset = "0x1FB7AD4", VA = "0x1FB7AD4")]
		public _003CAddPetSkillByPetSkillData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600F93B")]
		[Address(RVA = "0x1FB7ADC", Offset = "0x1FB7ADC", VA = "0x1FB7ADC")]
		internal bool _003C_003Em__0(UIHudSkillTemplateController temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200280B")]
	private sealed class _003CRemovePetSkillByType_003Ec__AnonStorey4
	{
		[Token(Token = "0x400F731")]
		[FieldOffset(Offset = "0x8")]
		internal string petSkillType;

		[Token(Token = "0x600F93C")]
		[Address(RVA = "0x1FB7FEC", Offset = "0x1FB7FEC", VA = "0x1FB7FEC")]
		public _003CRemovePetSkillByType_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x600F93D")]
		[Address(RVA = "0x1FB7FF4", Offset = "0x1FB7FF4", VA = "0x1FB7FF4")]
		internal bool _003C_003Em__0(UIHudSkillTemplateController temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200280C")]
	private sealed class _003COnPetSkillBufferStart_003Ec__AnonStorey5
	{
		[Token(Token = "0x400F732")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudPetSkillBufferController petSkillBuffer;

		[Token(Token = "0x400F733")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudPlayerStatsController _0024this;

		[Token(Token = "0x600F93E")]
		[Address(RVA = "0x1FB7CFC", Offset = "0x1FB7CFC", VA = "0x1FB7CFC")]
		public _003COnPetSkillBufferStart_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x600F93F")]
		[Address(RVA = "0x1FB7D04", Offset = "0x1FB7D04", VA = "0x1FB7D04")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200280D")]
	private sealed class _003COnBuffBehaviorChanged_003Ec__AnonStorey6
	{
		[Token(Token = "0x400F734")]
		[FieldOffset(Offset = "0x8")]
		internal CBIKNJDAGLO bevData;

		[Token(Token = "0x600F940")]
		[Address(RVA = "0x1FB7C10", Offset = "0x1FB7C10", VA = "0x1FB7C10")]
		public _003COnBuffBehaviorChanged_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x600F941")]
		[Address(RVA = "0x1FB7C18", Offset = "0x1FB7C18", VA = "0x1FB7C18")]
		internal bool _003C_003Em__0(CBIKNJDAGLO temp)
		{
			return default(bool);
		}

		[Token(Token = "0x600F942")]
		[Address(RVA = "0x1FB7C64", Offset = "0x1FB7C64", VA = "0x1FB7C64")]
		internal bool _003C_003Em__1(CBIKNJDAGLO temp)
		{
			return default(bool);
		}

		[Token(Token = "0x600F943")]
		[Address(RVA = "0x1FB7CB0", Offset = "0x1FB7CB0", VA = "0x1FB7CB0")]
		internal bool _003C_003Em__2(CBIKNJDAGLO temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400F6F7")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPlayerStatsView m_View;

	[Token(Token = "0x400F6F8")]
	[FieldOffset(Offset = "0x30")]
	private IHAAMHPPLMG m_BindPlayer;

	[Token(Token = "0x400F6F9")]
	[FieldOffset(Offset = "0x48")]
	private Player m_Player;

	[Token(Token = "0x400F6FA")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F6FB")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsPlayerDieing;

	[Token(Token = "0x400F6FC")]
	[FieldOffset(Offset = "0x54")]
	public readonly float ColorPlayerStatsAlpha;

	[Token(Token = "0x400F6FD")]
	[FieldOffset(Offset = "0x58")]
	public readonly Color ColorDisableEquipmentStat;

	[Token(Token = "0x400F6FE")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsShowMedKitHp;

	[Token(Token = "0x400F6FF")]
	[FieldOffset(Offset = "0x6C")]
	private int MedKitHp;

	[Token(Token = "0x400F700")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsShowMushroomEp;

	[Token(Token = "0x400F701")]
	[FieldOffset(Offset = "0x74")]
	private int MushroomEp;

	[Token(Token = "0x400F702")]
	[FieldOffset(Offset = "0x78")]
	private int SkillMaxY;

	[Token(Token = "0x400F703")]
	[FieldOffset(Offset = "0x7C")]
	private int SkillMiddleY;

	[Token(Token = "0x400F704")]
	[FieldOffset(Offset = "0x80")]
	private int SkillLowY;

	[Token(Token = "0x400F705")]
	[FieldOffset(Offset = "0x84")]
	private int SkillOffSetY_LvSysShow;

	[Token(Token = "0x400F706")]
	[FieldOffset(Offset = "0x88")]
	private int LevelSysY_EPShow;

	[Token(Token = "0x400F707")]
	[FieldOffset(Offset = "0x8C")]
	private int LevelSysY_EPHide;

	[Token(Token = "0x400F708")]
	[FieldOffset(Offset = "0x90")]
	private bool m_ShowEp;

	[Token(Token = "0x400F709")]
	[FieldOffset(Offset = "0x91")]
	private bool m_InHypeMode;

	[Token(Token = "0x400F70A")]
	[FieldOffset(Offset = "0x94")]
	private float HypeNodePosY_EPShow;

	[Token(Token = "0x400F70B")]
	[FieldOffset(Offset = "0x98")]
	private float HypeNodePosY_EPHide;

	[Token(Token = "0x400F70C")]
	[FieldOffset(Offset = "0x9C")]
	private float m_LastEffectTime;

	[Token(Token = "0x400F70D")]
	[FieldOffset(Offset = "0xA0")]
	private float m_EffectAnimationTime;

	[Token(Token = "0x400F70E")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_DelayCallID;

	[Token(Token = "0x400F70F")]
	[FieldOffset(Offset = "0xA8")]
	private uint m_AddExpDelayCallID;

	[Token(Token = "0x400F710")]
	private const uint DynamicSkillCnt = 4u;

	[Token(Token = "0x400F711")]
	[FieldOffset(Offset = "0xAC")]
	private Dictionary<string, UIHudSkillTemplateController> m_SkillDict;

	[Token(Token = "0x400F712")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<string, UIHudDynamicSkillTemplateController> m_DynamicSkillDict;

	[Token(Token = "0x400F713")]
	[FieldOffset(Offset = "0xB4")]
	private List<UIHudPetSkillBufferController> m_PetBufferCtrlList;

	[Token(Token = "0x400F714")]
	[FieldOffset(Offset = "0xB8")]
	private UIHudSkillEffectCountingController m_ActiveSkillCountingCtrl;

	[Token(Token = "0x400F715")]
	[FieldOffset(Offset = "0xBC")]
	private UIHudSkillTemplateController m_OBActiveSkillCtrl;

	[Token(Token = "0x400F716")]
	[FieldOffset(Offset = "0xC0")]
	private UIHudSkillKnockDownBleedController m_KnockedDownBleedCtrl;

	[Token(Token = "0x400F717")]
	[FieldOffset(Offset = "0xC4")]
	private UIHudSkillStrengthenArmorController m_StrengthenArmorCtrl;

	[Token(Token = "0x400F718")]
	[FieldOffset(Offset = "0xC8")]
	private UIHudPlayerArmorStatsController m_PlayerArmorStatsCtrl;

	[Token(Token = "0x400F719")]
	[FieldOffset(Offset = "0xCC")]
	private List<UIHudSkillTemplateController> m_PetSkillCtrlList;

	[Token(Token = "0x400F71A")]
	[FieldOffset(Offset = "0xD0")]
	private List<UIHudDynamicSkillTemplateController> m_DynamicSkillCtrls;

	[Token(Token = "0x400F71B")]
	[FieldOffset(Offset = "0xD4")]
	private Player mLastSkillPlayer;

	[Token(Token = "0x400F71C")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_LongPressed;

	[Token(Token = "0x400F71D")]
	[FieldOffset(Offset = "0xDC")]
	private ELongPressType m_LongPressedType;

	[Token(Token = "0x400F71E")]
	[FieldOffset(Offset = "0xE0")]
	private ELongPressType m_CurShowType;

	[Token(Token = "0x400F71F")]
	[FieldOffset(Offset = "0xE4")]
	private UIVFXTrackController m_ExpVFXTrackCtrl;

	[Token(Token = "0x400F720")]
	[FieldOffset(Offset = "0xE8")]
	private UIHudFlagBattleHypeProcessBarController m_FlagBattleHypeProcessBarCtrl;

	[Token(Token = "0x400F721")]
	[FieldOffset(Offset = "0xEC")]
	private float m_fBemarkIceWallStartTimer;

	[Token(Token = "0x400F722")]
	[FieldOffset(Offset = "0xF0")]
	private float m_fBemarkIceWallEndTimer;

	[Token(Token = "0x400F723")]
	[FieldOffset(Offset = "0xF4")]
	private bool m_bIsShowBeMarkIceWall;

	[Token(Token = "0x400F724")]
	[FieldOffset(Offset = "0xF5")]
	private bool m_bIsSHowBeHurtExpendEPValue;

	[Token(Token = "0x400F725")]
	[FieldOffset(Offset = "0xF8")]
	private Color ARMORCOLOR;

	[Token(Token = "0x400F726")]
	[FieldOffset(Offset = "0x108")]
	private Color LIFECOLOR;

	[Token(Token = "0x400F727")]
	[FieldOffset(Offset = "0x118")]
	private List<CBIKNJDAGLO> m_CurrentBuffBehaivorList;

	[Token(Token = "0x400F728")]
	[FieldOffset(Offset = "0x11C")]
	private List<UIHudBuffTemplateController> m_ItemControllers;

	[Token(Token = "0x600F8D9")]
	[Address(RVA = "0x186A5A0", Offset = "0x186A5A0", VA = "0x186A5A0")]
	public UIHudPlayerStatsController()
	{
	}

	[Token(Token = "0x600F8DA")]
	[Address(RVA = "0x186A878", Offset = "0x186A878", VA = "0x186A878")]
	private void OnMedkitHpChange(object[] data)
	{
	}

	[Token(Token = "0x600F8DB")]
	[Address(RVA = "0x186B624", Offset = "0x186B624", VA = "0x186B624")]
	private void OnMushRoomDataChange(object[] data)
	{
	}

	[Token(Token = "0x600F8DC")]
	[Address(RVA = "0x186B72C", Offset = "0x186B72C", VA = "0x186B72C")]
	private void OnMushRoomEpChange(object[] data)
	{
	}

	[Token(Token = "0x600F8DD")]
	[Address(RVA = "0x186C708", Offset = "0x186C708", VA = "0x186C708")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F8DE")]
	[Address(RVA = "0x186C7AC", Offset = "0x186C7AC", VA = "0x186C7AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F8DF")]
	[Address(RVA = "0x186D9C8", Offset = "0x186D9C8", VA = "0x186D9C8")]
	private void SyncBeMarkIceWall(object[] data)
	{
	}

	[Token(Token = "0x600F8E0")]
	[Address(RVA = "0x186DBFC", Offset = "0x186DBFC", VA = "0x186DBFC")]
	private void RefreshBeMarkIceWallUI()
	{
	}

	[Token(Token = "0x600F8E1")]
	[Address(RVA = "0x186D614", Offset = "0x186D614", VA = "0x186D614")]
	private void InitSkillTemplatePool()
	{
	}

	[Token(Token = "0x600F8E2")]
	[Address(RVA = "0x186E09C", Offset = "0x186E09C", VA = "0x186E09C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F8E3")]
	[Address(RVA = "0x186FDE8", Offset = "0x186FDE8", VA = "0x186FDE8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F8E4")]
	[Address(RVA = "0x1871280", Offset = "0x1871280", VA = "0x1871280")]
	private void Update()
	{
	}

	[Token(Token = "0x600F8E5")]
	[Address(RVA = "0x18718BC", Offset = "0x18718BC", VA = "0x18718BC")]
	private void UpdateBeHurtExpendEPValueIcon()
	{
	}

	[Token(Token = "0x600F8E6")]
	[Address(RVA = "0x1871B90", Offset = "0x1871B90", VA = "0x1871B90")]
	public void ShowInitSkillEffect()
	{
	}

	[Token(Token = "0x600F8E7")]
	[Address(RVA = "0x1871D64", Offset = "0x1871D64", VA = "0x1871D64")]
	public void OnSkillEffectShow(object[] data)
	{
	}

	[Token(Token = "0x600F8E8")]
	[Address(RVA = "0x1871FB8", Offset = "0x1871FB8", VA = "0x1871FB8")]
	public void OnSkillBrightAnim(object[] data)
	{
	}

	[Token(Token = "0x600F8E9")]
	[Address(RVA = "0x18722D8", Offset = "0x18722D8", VA = "0x18722D8")]
	public void OnPetSkillBrightAnim(object[] data)
	{
	}

	[Token(Token = "0x600F8EA")]
	[Address(RVA = "0x1872658", Offset = "0x1872658", VA = "0x1872658")]
	public void OnSkillFlashAnim(object[] data)
	{
	}

	[Token(Token = "0x600F8EB")]
	[Address(RVA = "0x1872900", Offset = "0x1872900", VA = "0x1872900")]
	public void OnSkillSpecialAnim(object[] data)
	{
	}

	[Token(Token = "0x600F8EC")]
	[Address(RVA = "0x1872BE8", Offset = "0x1872BE8", VA = "0x1872BE8")]
	public void OnSkillCoolDownAnim(object[] data)
	{
	}

	[Token(Token = "0x600F8ED")]
	[Address(RVA = "0x1872F80", Offset = "0x1872F80", VA = "0x1872F80")]
	private void OnPetSkillCoolDownAnim(object[] data)
	{
	}

	[Token(Token = "0x600F8EE")]
	[Address(RVA = "0x1873368", Offset = "0x1873368", VA = "0x1873368")]
	private void OnPetSkillCoolDownSPEAnim(object[] data)
	{
	}

	[Token(Token = "0x600F8EF")]
	[Address(RVA = "0x1873750", Offset = "0x1873750", VA = "0x1873750")]
	public void OnMarkedByPetSkillCuringEnemy(object[] data)
	{
	}

	[Token(Token = "0x600F8F0")]
	[Address(RVA = "0x18710F4", Offset = "0x18710F4", VA = "0x18710F4")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600F8F1")]
	[Address(RVA = "0x1873A58", Offset = "0x1873A58", VA = "0x1873A58", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600F8F2")]
	[Address(RVA = "0x1873AC4", Offset = "0x1873AC4", VA = "0x1873AC4")]
	private void HideCuringEnemy()
	{
	}

	[Token(Token = "0x600F8F3")]
	[Address(RVA = "0x1873BA0", Offset = "0x1873BA0", VA = "0x1873BA0")]
	private void OnLifeCountChanged(object[] data)
	{
	}

	[Token(Token = "0x600F8F4")]
	[Address(RVA = "0x1873D8C", Offset = "0x1873D8C", VA = "0x1873D8C")]
	private void RefreshLifeCount()
	{
	}

	[Token(Token = "0x600F8F5")]
	[Address(RVA = "0x1873FEC", Offset = "0x1873FEC", VA = "0x1873FEC")]
	private void OnAPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F8F6")]
	[Address(RVA = "0x187438C", Offset = "0x187438C", VA = "0x187438C")]
	private void OnMAXChanged(object[] data)
	{
	}

	[Token(Token = "0x600F8F7")]
	[Address(RVA = "0x18741D8", Offset = "0x18741D8", VA = "0x18741D8")]
	private void RefreshAP()
	{
	}

	[Token(Token = "0x600F8F8")]
	[Address(RVA = "0x1874578", Offset = "0x1874578", VA = "0x1874578")]
	private void RefreshAPIcon()
	{
	}

	[Token(Token = "0x600F8F9")]
	[Address(RVA = "0x1874B0C", Offset = "0x1874B0C", VA = "0x1874B0C")]
	private void OnExtraLifeObsoleted(object[] data)
	{
	}

	[Token(Token = "0x600F8FA")]
	[Address(RVA = "0x1874C48", Offset = "0x1874C48", VA = "0x1874C48")]
	private void OnIntroInfoChange(object[] data)
	{
	}

	[Token(Token = "0x600F8FB")]
	[Address(RVA = "0x1874D84", Offset = "0x1874D84", VA = "0x1874D84")]
	private void OnEnterRebornFinalStage(object[] data)
	{
	}

	[Token(Token = "0x600F8FC")]
	[Address(RVA = "0x1874DEC", Offset = "0x1874DEC", VA = "0x1874DEC")]
	public void BindPlayer(IHAAMHPPLMG pID)
	{
	}

	[Token(Token = "0x600F8FD")]
	[Address(RVA = "0x187516C", Offset = "0x187516C", VA = "0x187516C")]
	private void UpdateMarkStatus(bool show)
	{
	}

	[Token(Token = "0x600F8FE")]
	[Address(RVA = "0x1877A70", Offset = "0x1877A70", VA = "0x1877A70")]
	private void OnPlayerPostInit(object[] data)
	{
	}

	[Token(Token = "0x600F8FF")]
	[Address(RVA = "0x187847C", Offset = "0x187847C", VA = "0x187847C")]
	private void OnHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F900")]
	[Address(RVA = "0x1878908", Offset = "0x1878908", VA = "0x1878908")]
	private void OnShowTutorialHP(object[] data)
	{
	}

	[Token(Token = "0x600F901")]
	[Address(RVA = "0x1878A44", Offset = "0x1878A44", VA = "0x1878A44")]
	private void OnInventoryPickup(object[] param)
	{
	}

	[Token(Token = "0x600F902")]
	[Address(RVA = "0x1878D60", Offset = "0x1878D60", VA = "0x1878D60")]
	private void OnMAXHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F903")]
	[Address(RVA = "0x1879288", Offset = "0x1879288", VA = "0x1879288")]
	private void OnEPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F904")]
	[Address(RVA = "0x1879474", Offset = "0x1879474", VA = "0x1879474")]
	private void OnEXPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F905")]
	[Address(RVA = "0x1879AF8", Offset = "0x1879AF8", VA = "0x1879AF8")]
	private void OnLevelChanged(object[] data)
	{
	}

	[Token(Token = "0x600F906")]
	[Address(RVA = "0x186B840", Offset = "0x186B840", VA = "0x186B840")]
	private void RefreshEP()
	{
	}

	[Token(Token = "0x600F907")]
	[Address(RVA = "0x1878F48", Offset = "0x1878F48", VA = "0x1878F48")]
	private void RefreshMAXHP(object[] data)
	{
	}

	[Token(Token = "0x600F908")]
	[Address(RVA = "0x186AAA0", Offset = "0x186AAA0", VA = "0x186AAA0")]
	private void RefreshHP(object[] data)
	{
	}

	[Token(Token = "0x600F909")]
	[Address(RVA = "0x1878158", Offset = "0x1878158", VA = "0x1878158")]
	private void RefreshExp()
	{
	}

	[Token(Token = "0x600F90A")]
	[Address(RVA = "0x1879D50", Offset = "0x1879D50", VA = "0x1879D50")]
	private void RefreshLevel()
	{
	}

	[Token(Token = "0x600F90B")]
	[Address(RVA = "0x18714B8", Offset = "0x18714B8", VA = "0x18714B8")]
	private string GetLongPressDescription(ELongPressType pressType)
	{
		return null;
	}

	[Token(Token = "0x600F90C")]
	[Address(RVA = "0x1879F6C", Offset = "0x1879F6C", VA = "0x1879F6C")]
	private void ReplayForceUpdateUI(object[] data)
	{
	}

	[Token(Token = "0x600F90D")]
	[Address(RVA = "0x187A0E4", Offset = "0x187A0E4", VA = "0x187A0E4")]
	private void OnAddPlayer(object[] data)
	{
	}

	[Token(Token = "0x600F90E")]
	[Address(RVA = "0x187A24C", Offset = "0x187A24C", VA = "0x187A24C")]
	private void OnObservePlayer(object[] data)
	{
	}

	[Token(Token = "0x600F90F")]
	[Address(RVA = "0x187A520", Offset = "0x187A520", VA = "0x187A520")]
	private void OnRemoveMapMark(object[] data)
	{
	}

	[Token(Token = "0x600F910")]
	[Address(RVA = "0x187A708", Offset = "0x187A708", VA = "0x187A708")]
	private void OnUpdateMapMark(object[] data)
	{
	}

	[Token(Token = "0x600F911")]
	[Address(RVA = "0x187A968", Offset = "0x187A968", VA = "0x187A968")]
	private void OnKnockDownFlagChange(object[] data)
	{
	}

	[Token(Token = "0x600F912")]
	[Address(RVA = "0x187ABC0", Offset = "0x187ABC0", VA = "0x187ABC0")]
	private void OnAddPetSkill(object[] data)
	{
	}

	[Token(Token = "0x600F913")]
	[Address(RVA = "0x187B34C", Offset = "0x187B34C", VA = "0x187B34C")]
	private void AddPetSkillByPetSkillData(object[] data)
	{
	}

	[Token(Token = "0x600F914")]
	[Address(RVA = "0x187B698", Offset = "0x187B698", VA = "0x187B698")]
	private void RemovePetSkillByType(object[] data)
	{
	}

	[Token(Token = "0x600F915")]
	[Address(RVA = "0x187BAE0", Offset = "0x187BAE0", VA = "0x187BAE0")]
	private void OnShowWeaponDamageEnhance(object[] data)
	{
	}

	[Token(Token = "0x600F916")]
	[Address(RVA = "0x187BDC8", Offset = "0x187BDC8", VA = "0x187BDC8")]
	private void OnWeaponDamageRateChanged(object[] data)
	{
	}

	[Token(Token = "0x600F917")]
	[Address(RVA = "0x187C14C", Offset = "0x187C14C", VA = "0x187C14C")]
	private void OnShowAntiCloth(object[] data)
	{
	}

	[Token(Token = "0x600F918")]
	[Address(RVA = "0x187AF88", Offset = "0x187AF88", VA = "0x187AF88")]
	private void RepositionSkills()
	{
	}

	[Token(Token = "0x600F919")]
	[Address(RVA = "0x1875974", Offset = "0x1875974", VA = "0x1875974")]
	private void RefreshSkillStatus(DEHNALLDFNB reason = DEHNALLDFNB.ESkillChangeReason_Unknown, [Optional] HashSet<uint> newSkillIDs)
	{
	}

	[Token(Token = "0x600F91A")]
	[Address(RVA = "0x187C54C", Offset = "0x187C54C", VA = "0x187C54C")]
	private void PlayVFXTrack(Vector3 startPos, Vector3 endPos)
	{
	}

	[Token(Token = "0x600F91B")]
	[Address(RVA = "0x1877DA0", Offset = "0x1877DA0", VA = "0x1877DA0")]
	private void CheckSkillNeedShowCDAnim()
	{
	}

	[Token(Token = "0x600F91C")]
	[Address(RVA = "0x187CACC", Offset = "0x187CACC", VA = "0x187CACC")]
	public void CreateHypeModeProcessBar()
	{
	}

	[Token(Token = "0x600F91D")]
	[Address(RVA = "0x187D248", Offset = "0x187D248", VA = "0x187D248")]
	private void OnTrainingZoneChanged(object[] param)
	{
	}

	[Token(Token = "0x600F91E")]
	[Address(RVA = "0x187D360", Offset = "0x187D360", VA = "0x187D360")]
	private void OnShowMushroomEpTutorial(object[] param)
	{
	}

	[Token(Token = "0x600F91F")]
	[Address(RVA = "0x187D49C", Offset = "0x187D49C", VA = "0x187D49C")]
	private void OnShowEPChangeTutorial(object[] param)
	{
	}

	[Token(Token = "0x600F920")]
	[Address(RVA = "0x187C6CC", Offset = "0x187C6CC", VA = "0x187C6CC")]
	private void OnPetSkillBufferStart(object[] param)
	{
	}

	[Token(Token = "0x600F921")]
	[Address(RVA = "0x187D66C", Offset = "0x187D66C", VA = "0x187D66C")]
	private void OnActiveSkillCountingStart(object[] param)
	{
	}

	[Token(Token = "0x600F922")]
	[Address(RVA = "0x18755C8", Offset = "0x18755C8", VA = "0x18755C8")]
	private void OnPlayerKnockedDownBleedStateChanged(object[] param)
	{
	}

	[Token(Token = "0x600F923")]
	[Address(RVA = "0x187D8C0", Offset = "0x187D8C0", VA = "0x187D8C0")]
	private void OnActiveSkillCountingEnd(object[] param)
	{
	}

	[Token(Token = "0x600F924")]
	[Address(RVA = "0x187C270", Offset = "0x187C270", VA = "0x187C270")]
	private void UpdateOBActiveSkillIcon(AvatarSkillData data, bool isDynamic)
	{
	}

	[Token(Token = "0x600F925")]
	[Address(RVA = "0x186DE14", Offset = "0x186DE14", VA = "0x186DE14")]
	private UIHudSkillTemplateController OpenSkillTemplateFromPool(Transform transform)
	{
		return null;
	}

	[Token(Token = "0x600F926")]
	[Address(RVA = "0x187D9C4", Offset = "0x187D9C4", VA = "0x187D9C4")]
	private void OnAndrewSkillEffectCountChange(object[] data)
	{
	}

	[Token(Token = "0x600F927")]
	[Address(RVA = "0x187DD34", Offset = "0x187DD34", VA = "0x187DD34")]
	private void OnEnquipmentEquipStateChanged(object[] InParams)
	{
	}

	[Token(Token = "0x600F928")]
	[Address(RVA = "0x1877738", Offset = "0x1877738", VA = "0x1877738")]
	private void RefreshStrengthenArmorUI()
	{
	}

	[Token(Token = "0x600F929")]
	[Address(RVA = "0x187DF58", Offset = "0x187DF58", VA = "0x187DF58")]
	protected void OnBuffBehaviorChanged(object[] param)
	{
	}

	[Token(Token = "0x600F92A")]
	[Address(RVA = "0x187E7E8", Offset = "0x187E7E8", VA = "0x187E7E8")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600F92B")]
	[Address(RVA = "0x187EE34", Offset = "0x187EE34", VA = "0x187EE34")]
	private void OnSkillChanged(object[] data)
	{
	}

	[Token(Token = "0x600F92C")]
	[Address(RVA = "0x187F09C", Offset = "0x187F09C", VA = "0x187F09C")]
	private void _003COnUIOpen_003Em__0(bool press)
	{
	}

	[Token(Token = "0x600F92D")]
	[Address(RVA = "0x187F0AC", Offset = "0x187F0AC", VA = "0x187F0AC")]
	private void _003COnUIOpen_003Em__1(bool press)
	{
	}

	[Token(Token = "0x600F92E")]
	[Address(RVA = "0x187F0BC", Offset = "0x187F0BC", VA = "0x187F0BC")]
	private void _003COnUIOpen_003Em__2(bool press)
	{
	}

	[Token(Token = "0x600F92F")]
	[Address(RVA = "0x187F0CC", Offset = "0x187F0CC", VA = "0x187F0CC")]
	private void _003COnEXPChanged_003Em__3()
	{
	}

	[Token(Token = "0x600F930")]
	[Address(RVA = "0x187F130", Offset = "0x187F130", VA = "0x187F130")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F931")]
	[Address(RVA = "0x187F138", Offset = "0x187F138", VA = "0x187F138")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F932")]
	[Address(RVA = "0x187F140", Offset = "0x187F140", VA = "0x187F140")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F933")]
	[Address(RVA = "0x187F148", Offset = "0x187F148", VA = "0x187F148")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
