using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200355D")]
public class UIFrontEndPreviewView : UIBaseView
{
	[Token(Token = "0x4015210")]
	[FieldOffset(Offset = "0x14")]
	public Transform CommonPanelContainer;

	[Token(Token = "0x4015211")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha TweenAnim;

	[Token(Token = "0x4015212")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GameObjectWeaponEventTrigger;

	[Token(Token = "0x4015213")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget UIWidgetWeaponEventTrigger;

	[Token(Token = "0x4015214")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x4015215")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget TopLeft;

	[Token(Token = "0x4015216")]
	[FieldOffset(Offset = "0x2C")]
	public Transform BundlePreviewTitle;

	[Token(Token = "0x4015217")]
	[FieldOffset(Offset = "0x30")]
	public UIButton UIButtonTreasureBoxProbability;

	[Token(Token = "0x4015218")]
	[FieldOffset(Offset = "0x34")]
	public Transform TransformTreasureBoxProbability;

	[Token(Token = "0x4015219")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Center;

	[Token(Token = "0x401521A")]
	[FieldOffset(Offset = "0x3C")]
	public Transform notificationContainer;

	[Token(Token = "0x401521B")]
	[FieldOffset(Offset = "0x40")]
	public Transform ProbabilityPosition_RightTop;

	[Token(Token = "0x401521C")]
	[FieldOffset(Offset = "0x44")]
	public Transform ProbabilityPosition_Default;

	[Token(Token = "0x401521D")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget Left;

	[Token(Token = "0x401521E")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BackpackLevel;

	[Token(Token = "0x401521F")]
	[FieldOffset(Offset = "0x50")]
	public Transform HairStyleLevel;

	[Token(Token = "0x4015220")]
	[FieldOffset(Offset = "0x54")]
	public GameObject WeaponSkinUpgradeLevel;

	[Token(Token = "0x4015221")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget Right;

	[Token(Token = "0x4015222")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BackpackLevelRight;

	[Token(Token = "0x4015223")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid IconGrid;

	[Token(Token = "0x4015224")]
	[FieldOffset(Offset = "0x64")]
	public UIButton UIButtonInstallmentInfoBtn;

	[Token(Token = "0x4015225")]
	[FieldOffset(Offset = "0x68")]
	public UISprite UISpriteInstallmentInfoBtn;

	[Token(Token = "0x4015226")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject InstallmentEffect;

	[Token(Token = "0x4015227")]
	[FieldOffset(Offset = "0x70")]
	public UIButton MagnifierBtn;

	[Token(Token = "0x4015228")]
	[FieldOffset(Offset = "0x74")]
	public GameObject enlargeSprite;

	[Token(Token = "0x4015229")]
	[FieldOffset(Offset = "0x78")]
	public GameObject deflateSprite;

	[Token(Token = "0x401522A")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton zoomBtn;

	[Token(Token = "0x401522B")]
	[FieldOffset(Offset = "0x80")]
	public GameObject zoomSprite;

	[Token(Token = "0x401522C")]
	[FieldOffset(Offset = "0x84")]
	public GameObject PlaySprite;

	[Token(Token = "0x401522D")]
	[FieldOffset(Offset = "0x88")]
	public UIButton switchbtn;

	[Token(Token = "0x401522E")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject SwitchToGunSpr;

	[Token(Token = "0x401522F")]
	[FieldOffset(Offset = "0x90")]
	public GameObject SwitchToPersonSpr;

	[Token(Token = "0x4015230")]
	[FieldOffset(Offset = "0x94")]
	public UIButton backpckSwitch;

	[Token(Token = "0x4015231")]
	[FieldOffset(Offset = "0x98")]
	public GameObject SwitchTobackpackSpr;

	[Token(Token = "0x4015232")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject SwitchTobackpackPersonSpr;

	[Token(Token = "0x4015233")]
	[FieldOffset(Offset = "0xA0")]
	public UIButton ZoomWithCameraBtn;

	[Token(Token = "0x4015234")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject WeaponSkinUpgradeLevelRight;

	[Token(Token = "0x4015235")]
	[FieldOffset(Offset = "0xA8")]
	public UIWidget InstallmentInfo;

	[Token(Token = "0x4015236")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel RemainTerm;

	[Token(Token = "0x4015237")]
	[FieldOffset(Offset = "0xB0")]
	public UICountDownLabel RemainTime;

	[Token(Token = "0x4015238")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject HairStyleLevelright;

	[Token(Token = "0x4015239")]
	[FieldOffset(Offset = "0xB8")]
	public UIWidget TopRight;

	[Token(Token = "0x401523A")]
	[FieldOffset(Offset = "0xBC")]
	public UIWidget BottomLeft;

	[Token(Token = "0x401523B")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject ItemDesc;

	[Token(Token = "0x401523C")]
	[FieldOffset(Offset = "0xC4")]
	public UIWidget BottomRight;

	[Token(Token = "0x401523D")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject propertyContainer;

	[Token(Token = "0x401523E")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject VehicleSkinScoreTable;

	[Token(Token = "0x401523F")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject pvpPropertyContainer;

	[Token(Token = "0x4015240")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject pvePropertyContainer;

	[Token(Token = "0x4015241")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject pveweaponProperty;

	[Token(Token = "0x4015242")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject skillicon;

	[Token(Token = "0x4015243")]
	[FieldOffset(Offset = "0xE0")]
	public UIGrid toggleGrid;

	[Token(Token = "0x4015244")]
	[FieldOffset(Offset = "0xE4")]
	public UIToggleButton pvpToggle;

	[Token(Token = "0x4015245")]
	[FieldOffset(Offset = "0xE8")]
	public UIToggleButton pveToggle;

	[Token(Token = "0x4015246")]
	[FieldOffset(Offset = "0xEC")]
	public UIWidget Bottom;

	[Token(Token = "0x4015247")]
	[FieldOffset(Offset = "0xF0")]
	public UIWidget Top;

	[Token(Token = "0x4015248")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject ShowUIContainer;

	[Token(Token = "0x4015249")]
	[FieldOffset(Offset = "0xF8")]
	public Transform HotFixDownloadContainer;

	[Token(Token = "0x401524A")]
	[FieldOffset(Offset = "0xFC")]
	public UIButton WebShowBtn;

	[Token(Token = "0x401524B")]
	[FieldOffset(Offset = "0x100")]
	public UISprite WebShowSprite;

	[Token(Token = "0x401524C")]
	[FieldOffset(Offset = "0x104")]
	public Transform SkillInfoContainer;

	[Token(Token = "0x401524D")]
	[FieldOffset(Offset = "0x108")]
	public UILabel NotReadyLabel;

	[Token(Token = "0x60163C7")]
	[Address(RVA = "0xE91220", Offset = "0xE91220", VA = "0xE91220")]
	public UIFrontEndPreviewView()
	{
	}

	[Token(Token = "0x60163C8")]
	[Address(RVA = "0xE91228", Offset = "0xE91228", VA = "0xE91228", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163C9")]
	[Address(RVA = "0xE92828", Offset = "0xE92828", VA = "0xE92828")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
