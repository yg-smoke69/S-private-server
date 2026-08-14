using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C6F")]
public class FrontEndPreviewUIConfigData : CSVBaseData
{
	[Token(Token = "0x4010F47")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Vector3 INVALIDVECTOR3;

	[Token(Token = "0x4010F48")]
	[FieldOffset(Offset = "0xC")]
	public static readonly Vector4 INVALIDVECTOR4;

	[Token(Token = "0x4010F49")]
	[FieldOffset(Offset = "0x8")]
	public FrontendPreviewType FrontendPreviewType;

	[Token(Token = "0x4010F4A")]
	[FieldOffset(Offset = "0xC")]
	public UIFrontEndPreviewController.SkillTipsType SkillTipsType;

	[Token(Token = "0x4010F4B")]
	[FieldOffset(Offset = "0x10")]
	public UIFrontEndPreviewController.ProbabilityStyleType ProbabilityStyleType;

	[Token(Token = "0x4010F4C")]
	[FieldOffset(Offset = "0x14")]
	public UIFrontEndPreviewItemDescBaseStyle UIFrontEndPreviewItemDescStyle;

	[Token(Token = "0x4010F4D")]
	[FieldOffset(Offset = "0x18")]
	public UIFrontEndPreviewBundlePreviewStyle UIFrontEndPreviewBundlePreviewStyle;

	[Token(Token = "0x4010F4E")]
	[FieldOffset(Offset = "0x1C")]
	public UIFrontEndPreviewWeaponPropertyPanelStyle UIFrontEndPreviewWeaponPropertyPanelStyle;

	[Token(Token = "0x4010F4F")]
	[FieldOffset(Offset = "0x20")]
	public UIFrontEndPreviewVehiclePropertyPanelStyle UIFrontEndPreviewVehiclePropertyPanelStyle;

	[Token(Token = "0x4010F50")]
	[FieldOffset(Offset = "0x24")]
	public UIFrontEndPreviewWeaponSkinUpgradeStyle UIFrontEndPreviewWeaponSkinUpgradeStyle;

	[Token(Token = "0x4010F51")]
	[FieldOffset(Offset = "0x28")]
	public UIFrontEndPreviewBackpackLevelStyle UIFrontEndPreviewBackpackLevelStyle;

	[Token(Token = "0x4010F52")]
	[FieldOffset(Offset = "0x2C")]
	public UIFrontEndPreviewHairStyleLevelStyle UIFrontEndPreviewHairStyleLevelStyle;

	[Token(Token = "0x4010F53")]
	[FieldOffset(Offset = "0x30")]
	public UIFrontEndPreviewPveWeaponPropertyStyle UIFrontEndPreviewPveWeaponPropertyStyle;

	[Token(Token = "0x4010F54")]
	[FieldOffset(Offset = "0x34")]
	public UIFrontEndPreviewHotfixDownloadStyle UIFrontEndPreviewHotfixDownloadStyle;

	[Token(Token = "0x4010F55")]
	[FieldOffset(Offset = "0x38")]
	public UIFrontEndPreviewDetailSkillInfoPanelStyle UIFrontEndPreviewDetailSkillInfoPanelStyle;

	[Token(Token = "0x4010F56")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 SkillInfoPos;

	[Token(Token = "0x4010F57")]
	[FieldOffset(Offset = "0x48")]
	public EUIAnchor SkillInfoAnchor;

	[Token(Token = "0x4010F58")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 ItemDescPos;

	[Token(Token = "0x4010F59")]
	[FieldOffset(Offset = "0x58")]
	public EUIAnchor ItemDescAnchor;

	[Token(Token = "0x4010F5A")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 BundlePreviewTitlePos;

	[Token(Token = "0x4010F5B")]
	[FieldOffset(Offset = "0x68")]
	public EUIAnchor BundlePreviewTitleAnchor;

	[Token(Token = "0x4010F5C")]
	[FieldOffset(Offset = "0x6C")]
	public Vector3 BackPackLevelPos;

	[Token(Token = "0x4010F5D")]
	[FieldOffset(Offset = "0x78")]
	public EUIAnchor BackPackLevelAnchor;

	[Token(Token = "0x4010F5E")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 BackPackLevelRightPos;

	[Token(Token = "0x4010F5F")]
	[FieldOffset(Offset = "0x88")]
	public EUIAnchor BackPackLevelRightAnchor;

	[Token(Token = "0x4010F60")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 PropertyIconTablePos;

	[Token(Token = "0x4010F61")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 PropertyContainerPos;

	[Token(Token = "0x4010F62")]
	[FieldOffset(Offset = "0xA4")]
	public EUIAnchor PropertyContainerAnchor;

	[Token(Token = "0x4010F63")]
	[FieldOffset(Offset = "0xA8")]
	public Vector3 HairStyleLevelPos;

	[Token(Token = "0x4010F64")]
	[FieldOffset(Offset = "0xB4")]
	public EUIAnchor HairStyleLevelAnchor;

	[Token(Token = "0x4010F65")]
	[FieldOffset(Offset = "0xB8")]
	public Vector3 NotificationContainerPos;

	[Token(Token = "0x4010F66")]
	[FieldOffset(Offset = "0xC4")]
	public EUIAnchor NotificationContainerAnchor;

	[Token(Token = "0x4010F67")]
	[FieldOffset(Offset = "0xC8")]
	public Vector3 WeaponSkinUpgradeLevelPos;

	[Token(Token = "0x4010F68")]
	[FieldOffset(Offset = "0xD4")]
	public EUIAnchor WeaponSkinUpgradeLevelAnchor;

	[Token(Token = "0x4010F69")]
	[FieldOffset(Offset = "0xD8")]
	public Vector3 WeaponSkinUpgradeLevelRightPos;

	[Token(Token = "0x4010F6A")]
	[FieldOffset(Offset = "0xE4")]
	public EUIAnchor WeaponSkinUpgradeLevelRightAnchor;

	[Token(Token = "0x4010F6B")]
	[FieldOffset(Offset = "0xE8")]
	public Vector3 IconGridPos;

	[Token(Token = "0x4010F6C")]
	[FieldOffset(Offset = "0xF4")]
	public EUIAnchor IconGridAnchor;

	[Token(Token = "0x4010F6D")]
	[FieldOffset(Offset = "0xF8")]
	public Vector3 HairStyleLevelRightPos;

	[Token(Token = "0x4010F6E")]
	[FieldOffset(Offset = "0x104")]
	public EUIAnchor HairStyleLevelRightAnchor;

	[Token(Token = "0x4010F6F")]
	[FieldOffset(Offset = "0x108")]
	public Vector3 UIItemViewIconPos;

	[Token(Token = "0x4010F70")]
	[FieldOffset(Offset = "0x114")]
	public Vector3 UIBannerViewPos;

	[Token(Token = "0x4010F71")]
	[FieldOffset(Offset = "0x120")]
	public Vector3 UIHeadPicViewPos;

	[Token(Token = "0x4010F72")]
	[FieldOffset(Offset = "0x12C")]
	public bool NeedBagPackPreviewSwitch;

	[Token(Token = "0x4010F73")]
	[FieldOffset(Offset = "0x12D")]
	public bool NeedEfeectIconChangeGrid;

	[Token(Token = "0x4010F74")]
	[FieldOffset(Offset = "0x12E")]
	public bool NeedZoomBtn;

	[Token(Token = "0x4010F75")]
	[FieldOffset(Offset = "0x12F")]
	public bool NeedMagnifierBtn;

	[Token(Token = "0x4010F76")]
	[FieldOffset(Offset = "0x130")]
	public bool NeedSexIcon;

	[Token(Token = "0x4010F77")]
	[FieldOffset(Offset = "0x131")]
	public bool NeedMagnifierFacial;

	[Token(Token = "0x4010F78")]
	[FieldOffset(Offset = "0x132")]
	public bool NeedLogMagnifierClick;

	[Token(Token = "0x4010F79")]
	[FieldOffset(Offset = "0x133")]
	public bool NeedEffectIcon;

	[Token(Token = "0x4010F7A")]
	[FieldOffset(Offset = "0x134")]
	public bool NeedOptionalDownloadRefresh;

	[Token(Token = "0x4010F7B")]
	[FieldOffset(Offset = "0x135")]
	public bool NeedShowEpicClothStyle;

	[Token(Token = "0x4010F7C")]
	[FieldOffset(Offset = "0x136")]
	public bool NeedShowHairStyleIcon;

	[Token(Token = "0x4010F7D")]
	[FieldOffset(Offset = "0x137")]
	public bool NeedBackpackLevel;

	[Token(Token = "0x4010F7E")]
	[FieldOffset(Offset = "0x138")]
	public bool NeedWeaponSwitchBtn;

	[Token(Token = "0x4010F7F")]
	[FieldOffset(Offset = "0x139")]
	public bool NeedShowDownloadAllBtn;

	[Token(Token = "0x4010F80")]
	[FieldOffset(Offset = "0x13A")]
	public bool NeedAdjustPropertyContainer;

	[Token(Token = "0x4010F81")]
	[FieldOffset(Offset = "0x13B")]
	public bool NeedAdjustPropertySkillInfoPanel;

	[Token(Token = "0x4010F82")]
	[FieldOffset(Offset = "0x13C")]
	public ResDownloadType DownloadAllType;

	[Token(Token = "0x4010F83")]
	[FieldOffset(Offset = "0x140")]
	public string DownloadText;

	[Token(Token = "0x4010F84")]
	[FieldOffset(Offset = "0x144")]
	public float Preview2DItemScale;

	[Token(Token = "0x4010F85")]
	[FieldOffset(Offset = "0x148")]
	public bool UIItemDescShow;

	[Token(Token = "0x4010F86")]
	[FieldOffset(Offset = "0x14C")]
	public Vector4 UIBundleScrollViewRegion;

	[Token(Token = "0x6012867")]
	[Address(RVA = "0x104E8E8", Offset = "0x104E8E8", VA = "0x104E8E8")]
	public FrontEndPreviewUIConfigData()
	{
	}

	[Token(Token = "0x6012868")]
	[Address(RVA = "0x104E974", Offset = "0x104E974", VA = "0x104E974", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6012869")]
	[Address(RVA = "0x104EA74", Offset = "0x104EA74", VA = "0x104EA74", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x601286A")]
	[Address(RVA = "0x104F744", Offset = "0x104F744", VA = "0x104F744")]
	public Vector3 TransStringToVector3(string head, string[] headers, string[] values)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601286B")]
	[Address(RVA = "0x104F9E8", Offset = "0x104F9E8", VA = "0x104F9E8")]
	public Vector4 TransStringToVector4(string head, string[] headers, string[] values)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector4);
	}
}
