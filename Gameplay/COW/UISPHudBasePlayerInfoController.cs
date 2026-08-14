using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002B27")]
public class UISPHudBasePlayerInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x40108B7")]
	[FieldOffset(Offset = "0x28")]
	protected SPHudPlayerInfoType m_Type;

	[Token(Token = "0x40108B8")]
	[FieldOffset(Offset = "0x2C")]
	protected UISPHudNewPlayerInfoView m_View;

	[Token(Token = "0x40108B9")]
	[FieldOffset(Offset = "0x30")]
	protected UISPHudCSPlayerInfoView m_CSView;

	[Token(Token = "0x40108BA")]
	[FieldOffset(Offset = "0x34")]
	protected GameObject EPNode;

	[Token(Token = "0x40108BB")]
	[FieldOffset(Offset = "0x38")]
	protected UISprite EPBar;

	[Token(Token = "0x40108BC")]
	[FieldOffset(Offset = "0x3C")]
	protected UILabel LabelHP;

	[Token(Token = "0x40108BD")]
	[FieldOffset(Offset = "0x40")]
	protected UISprite HPBar;

	[Token(Token = "0x40108BE")]
	[FieldOffset(Offset = "0x44")]
	protected UISprite TeamFakeIcon;

	[Token(Token = "0x40108BF")]
	[FieldOffset(Offset = "0x48")]
	protected UIEffectSprite TeamIcon;

	[Token(Token = "0x40108C0")]
	[FieldOffset(Offset = "0x4C")]
	protected UIEffectSprite FlagIcon;

	[Token(Token = "0x40108C1")]
	[FieldOffset(Offset = "0x50")]
	protected UILabel TeamId;

	[Token(Token = "0x40108C2")]
	[FieldOffset(Offset = "0x54")]
	protected UILabel TeamName;

	[Token(Token = "0x40108C3")]
	[FieldOffset(Offset = "0x58")]
	protected UILabel Name;

	[Token(Token = "0x40108C4")]
	[FieldOffset(Offset = "0x5C")]
	protected UILabel TeamRegion;

	[Token(Token = "0x40108C5")]
	[FieldOffset(Offset = "0x60")]
	protected UISprite TeamBG;

	[Token(Token = "0x40108C6")]
	[FieldOffset(Offset = "0x64")]
	protected UISprite NameBG;

	[Token(Token = "0x40108C7")]
	[FieldOffset(Offset = "0x68")]
	protected UISprite HelmetBG;

	[Token(Token = "0x40108C8")]
	[FieldOffset(Offset = "0x6C")]
	protected UISprite FilledHelmet;

	[Token(Token = "0x40108C9")]
	[FieldOffset(Offset = "0x70")]
	protected UISprite FilledHelmetEnhanced;

	[Token(Token = "0x40108CA")]
	[FieldOffset(Offset = "0x74")]
	protected UISprite HelmetLevel;

	[Token(Token = "0x40108CB")]
	[FieldOffset(Offset = "0x78")]
	protected UISprite ArmorBG;

	[Token(Token = "0x40108CC")]
	[FieldOffset(Offset = "0x7C")]
	protected UISprite FilledArmor;

	[Token(Token = "0x40108CD")]
	[FieldOffset(Offset = "0x80")]
	protected UISprite FilledArmorEnhanced;

	[Token(Token = "0x40108CE")]
	[FieldOffset(Offset = "0x84")]
	protected UISprite ArmorLevel;

	[Token(Token = "0x40108CF")]
	[FieldOffset(Offset = "0x88")]
	protected UILabel MedkitCount;

	[Token(Token = "0x40108D0")]
	[FieldOffset(Offset = "0x8C")]
	protected UILabel GrenadeCount;

	[Token(Token = "0x40108D1")]
	[FieldOffset(Offset = "0x90")]
	protected UILabel SmokingBombCount;

	[Token(Token = "0x40108D2")]
	[FieldOffset(Offset = "0x94")]
	protected UILabel IceWallCount;

	[Token(Token = "0x40108D3")]
	[FieldOffset(Offset = "0x98")]
	protected UISprite icon;

	[Token(Token = "0x40108D4")]
	[FieldOffset(Offset = "0x9C")]
	protected UILabel ItemCount;

	[Token(Token = "0x40108D5")]
	[FieldOffset(Offset = "0xA0")]
	protected UILabel Kill;

	[Token(Token = "0x40108D6")]
	[FieldOffset(Offset = "0xA4")]
	protected UILabel LabelKDA;

	[Token(Token = "0x40108D7")]
	[FieldOffset(Offset = "0xA8")]
	protected UISprite WeaponIcon;

	[Token(Token = "0x40108D8")]
	[FieldOffset(Offset = "0xAC")]
	protected Transform LeftAnchor;

	[Token(Token = "0x40108D9")]
	[FieldOffset(Offset = "0xB0")]
	protected UIGrid Skills;

	[Token(Token = "0x40108DA")]
	[FieldOffset(Offset = "0xB4")]
	protected UISPHudSkillItemView SkillTemplate;

	[Token(Token = "0x40108DB")]
	[FieldOffset(Offset = "0xB8")]
	protected UILabel Nation;

	[Token(Token = "0x40108DC")]
	[FieldOffset(Offset = "0xBC")]
	protected UISprite NationBg;

	[Token(Token = "0x40108DD")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel TokenNum;

	[Token(Token = "0x40108DE")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject Token;

	[Token(Token = "0x40108DF")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject ActiveSkill;

	[Token(Token = "0x40108E0")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite ActiveSkillIcon;

	[Token(Token = "0x40108E1")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite CDProgress;

	[Token(Token = "0x40108E2")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject CDMask;

	[Token(Token = "0x40108E3")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite DisableProgress;

	[Token(Token = "0x40108E4")]
	[FieldOffset(Offset = "0xDC")]
	public UISprite highLightSprite;

	[Token(Token = "0x40108E5")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite TakeEffectProgress;

	[Token(Token = "0x40108E6")]
	[FieldOffset(Offset = "0xE4")]
	public Transform FsHypeNode;

	[Token(Token = "0x40108E7")]
	[FieldOffset(Offset = "0xE8")]
	public Transform GoldEffect;

	[Token(Token = "0x40108E8")]
	[FieldOffset(Offset = "0xEC")]
	public Transform SpriteGoldPlus;

	[Token(Token = "0x40108E9")]
	[FieldOffset(Offset = "0xF0")]
	public Transform SpriteRedPlus;

	[Token(Token = "0x40108EA")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject GoGradeLv1;

	[Token(Token = "0x40108EB")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject GoGradeLv2;

	[Token(Token = "0x40108EC")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject GoGradeLv3;

	[Token(Token = "0x40108ED")]
	[FieldOffset(Offset = "0x100")]
	public GameObject QualityMark1;

	[Token(Token = "0x40108EE")]
	[FieldOffset(Offset = "0x104")]
	public GameObject QualityMark2;

	[Token(Token = "0x40108EF")]
	[FieldOffset(Offset = "0x108")]
	public GameObject QualityMark3;

	[Token(Token = "0x40108F0")]
	[FieldOffset(Offset = "0x10C")]
	internal Player m_CurrentTrackingPlayer;

	[Token(Token = "0x40108F1")]
	[FieldOffset(Offset = "0x110")]
	internal UIModelSpectator m_ModelSpectator;

	[Token(Token = "0x40108F2")]
	[FieldOffset(Offset = "0x114")]
	private bool m_IsPlayerDieing;

	[Token(Token = "0x40108F3")]
	[FieldOffset(Offset = "0x118")]
	private int curHelmetLevel;

	[Token(Token = "0x40108F4")]
	[FieldOffset(Offset = "0x11C")]
	private int curArmorLevel;

	[Token(Token = "0x40108F5")]
	[FieldOffset(Offset = "0x120")]
	private string FilledArmorIcon;

	[Token(Token = "0x40108F6")]
	[FieldOffset(Offset = "0x124")]
	private string FilledArmorIconBG;

	[Token(Token = "0x40108F7")]
	[FieldOffset(Offset = "0x128")]
	private string FilledArmorIconExplode;

	[Token(Token = "0x40108F8")]
	[FieldOffset(Offset = "0x12C")]
	private string FilledArmorIconExplodeBG;

	[Token(Token = "0x40108F9")]
	[FieldOffset(Offset = "0x130")]
	private string FilledHeadIcon;

	[Token(Token = "0x40108FA")]
	[FieldOffset(Offset = "0x134")]
	private string FilledHeadIconBG;

	[Token(Token = "0x40108FB")]
	[FieldOffset(Offset = "0x138")]
	private string FilledHeadIconProtect;

	[Token(Token = "0x40108FC")]
	[FieldOffset(Offset = "0x13C")]
	private string FilledHeadIconProtectBG;

	[Token(Token = "0x40108FD")]
	[FieldOffset(Offset = "0x140")]
	private AAHMJHHPECM m_CurItemOnHand;

	[Token(Token = "0x40108FE")]
	[FieldOffset(Offset = "0x144")]
	private GFLDMEPHOFG m_CurItemTypeOnHand;

	[Token(Token = "0x40108FF")]
	[FieldOffset(Offset = "0x148")]
	protected int weapon_origin_width;

	[Token(Token = "0x4010900")]
	[FieldOffset(Offset = "0x14C")]
	protected int weapon_origin_height;

	[Token(Token = "0x4010901")]
	[FieldOffset(Offset = "0x0")]
	protected static Color AmmoColorGolden;

	[Token(Token = "0x4010902")]
	[FieldOffset(Offset = "0x150")]
	private PFLCPEHBBLN curActiveSkill;

	[Token(Token = "0x6011BDE")]
	[Address(RVA = "0x1436490", Offset = "0x1436490", VA = "0x1436490")]
	public UISPHudBasePlayerInfoController()
	{
	}

	[Token(Token = "0x6011BDF")]
	[Address(RVA = "0x14365C0", Offset = "0x14365C0", VA = "0x14365C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011BE0")]
	[Address(RVA = "0x1436F24", Offset = "0x1436F24", VA = "0x1436F24", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011BE1")]
	[Address(RVA = "0x1437424", Offset = "0x1437424", VA = "0x1437424")]
	private void OnTokenChanged(object[] data)
	{
	}

	[Token(Token = "0x6011BE2")]
	[Address(RVA = "0x14376A0", Offset = "0x14376A0", VA = "0x14376A0")]
	private void OnMAXHPChanged(object[] data)
	{
	}

	[Token(Token = "0x6011BE3")]
	[Address(RVA = "0x1437888", Offset = "0x1437888", VA = "0x1437888")]
	private void RefreshMAXHP(object[] data)
	{
	}

	[Token(Token = "0x6011BE4")]
	[Address(RVA = "0x1437D90", Offset = "0x1437D90", VA = "0x1437D90")]
	private void OnHPChanged(object[] data)
	{
	}

	[Token(Token = "0x6011BE5")]
	[Address(RVA = "0x1437F78", Offset = "0x1437F78", VA = "0x1437F78")]
	private void RefreshHP(object[] data)
	{
	}

	[Token(Token = "0x6011BE6")]
	[Address(RVA = "0x1438570", Offset = "0x1438570", VA = "0x1438570")]
	private void OnEPChanged(object[] data)
	{
	}

	[Token(Token = "0x6011BE7")]
	[Address(RVA = "0x143875C", Offset = "0x143875C", VA = "0x143875C")]
	private void RefreshEP()
	{
	}

	[Token(Token = "0x6011BE8")]
	[Address(RVA = "0x14389A4", Offset = "0x14389A4", VA = "0x14389A4")]
	private void OnKnockDownFlagChange(object[] data)
	{
	}

	[Token(Token = "0x6011BE9")]
	[Address(RVA = "0x1438C78", Offset = "0x1438C78", VA = "0x1438C78")]
	private void RefreshEquipmentStats(BMGBKEENCJH InSlot = BMGBKEENCJH.Unknown)
	{
	}

	[Token(Token = "0x6011BEA")]
	[Address(RVA = "0x143A034", Offset = "0x143A034", VA = "0x143A034")]
	private void OnEnquipmentEquipStateChanged(object[] InParams)
	{
	}

	[Token(Token = "0x6011BEB")]
	[Address(RVA = "0x143A24C", Offset = "0x143A24C", VA = "0x143A24C")]
	private void UpdateMedkit()
	{
	}

	[Token(Token = "0x6011BEC")]
	[Address(RVA = "0x143A478", Offset = "0x143A478", VA = "0x143A478")]
	private void UpdateGrenade()
	{
	}

	[Token(Token = "0x6011BED")]
	[Address(RVA = "0x143A6A4", Offset = "0x143A6A4", VA = "0x143A6A4")]
	private void UpdateSmokingBomb()
	{
	}

	[Token(Token = "0x6011BEE")]
	[Address(RVA = "0x143A8D0", Offset = "0x143A8D0", VA = "0x143A8D0")]
	private void UpdateIceWall()
	{
	}

	[Token(Token = "0x6011BEF")]
	[Address(RVA = "0x143AAFC", Offset = "0x143AAFC", VA = "0x143AAFC")]
	private void OnItemChanged(object[] param)
	{
	}

	[Token(Token = "0x6011BF0")]
	[Address(RVA = "0x143B614", Offset = "0x143B614", VA = "0x143B614")]
	private void OnNewItemOnHand(object[] param)
	{
	}

	[Token(Token = "0x6011BF1")]
	[Address(RVA = "0x143AE78", Offset = "0x143AE78", VA = "0x143AE78")]
	private void RefreshItemUI(bool isNewOnHand, HICMEGJFGHB itemType = HICMEGJFGHB.EITEM_TYPE_GRENADE)
	{
	}

	[Token(Token = "0x6011BF2")]
	[Address(RVA = "0x143C2F4", Offset = "0x143C2F4", VA = "0x143C2F4")]
	private void RefreshUIWhenCountChanged(PlayerData data, HICMEGJFGHB itemType)
	{
	}

	[Token(Token = "0x6011BF3")]
	[Address(RVA = "0x143B7B8", Offset = "0x143B7B8", VA = "0x143B7B8")]
	private void RefreshWeaponUI()
	{
	}

	[Token(Token = "0x6011BF4")]
	[Address(RVA = "0x143C740", Offset = "0x143C740", VA = "0x143C740")]
	private void OnObserverSwitch(object[] data)
	{
	}

	[Token(Token = "0x6011BF5")]
	[Address(RVA = "0x143DE34", Offset = "0x143DE34", VA = "0x143DE34")]
	private void SetPlayerLabelColor(UILabel Text, ulong UserID)
	{
	}

	[Token(Token = "0x6011BF6")]
	[Address(RVA = "0x143D5E8", Offset = "0x143D5E8", VA = "0x143D5E8")]
	private void RefreshSkillStatus()
	{
	}

	[Token(Token = "0x6011BF7")]
	[Address(RVA = "0x143E168", Offset = "0x143E168", VA = "0x143E168")]
	protected void Update()
	{
	}

	[Token(Token = "0x6011BF8")]
	[Address(RVA = "0x143DF9C", Offset = "0x143DF9C", VA = "0x143DF9C")]
	private void SetBgColor(UISprite sp, char type, float alpha)
	{
	}

	[Token(Token = "0x6011BF9")]
	[Address(RVA = "0x143E1BC", Offset = "0x143E1BC", VA = "0x143E1BC")]
	private void OnSkillIconToggle(object[] data)
	{
	}

	[Token(Token = "0x6011BFA")]
	[Address(RVA = "0x143E394", Offset = "0x143E394", VA = "0x143E394", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011BFB")]
	[Address(RVA = "0x143E428", Offset = "0x143E428", VA = "0x143E428", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011BFC")]
	[Address(RVA = "0x143D454", Offset = "0x143D454", VA = "0x143D454")]
	private void RefreshLabelKill()
	{
	}

	[Token(Token = "0x6011BFD")]
	[Address(RVA = "0x143E8BC", Offset = "0x143E8BC", VA = "0x143E8BC")]
	private void OnAttachmentChanged(object[] param)
	{
	}

	[Token(Token = "0x6011BFE")]
	[Address(RVA = "0x1436DAC", Offset = "0x1436DAC", VA = "0x1436DAC")]
	private void CreateHypeModeProcessBar()
	{
	}

	[Token(Token = "0x6011C00")]
	[Address(RVA = "0x143EB34", Offset = "0x143EB34", VA = "0x143EB34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011C01")]
	[Address(RVA = "0x143EB3C", Offset = "0x143EB3C", VA = "0x143EB3C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
