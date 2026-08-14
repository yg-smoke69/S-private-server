using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B2")]
public class UIGraphicSettingView : UIBaseView
{
	[Token(Token = "0x4015750")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView SettingScrollView;

	[Token(Token = "0x4015751")]
	[FieldOffset(Offset = "0x18")]
	public UITable Table;

	[Token(Token = "0x4015752")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget QUALITY;

	[Token(Token = "0x4015753")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Desc;

	[Token(Token = "0x4015754")]
	[FieldOffset(Offset = "0x24")]
	public UITable QualityTable;

	[Token(Token = "0x4015755")]
	[FieldOffset(Offset = "0x28")]
	public GameObject QualityToggleGroup;

	[Token(Token = "0x4015756")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton UltraPlusQualityToggle;

	[Token(Token = "0x4015757")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton HighQualityToggle;

	[Token(Token = "0x4015758")]
	[FieldOffset(Offset = "0x34")]
	public GameObject UltraToggleArrow;

	[Token(Token = "0x4015759")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton LowQualityToggle;

	[Token(Token = "0x401575A")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton LowestQualityToggle;

	[Token(Token = "0x401575B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ExtraQualitySetting;

	[Token(Token = "0x401575C")]
	[FieldOffset(Offset = "0x44")]
	public GameObject resolutionObj;

	[Token(Token = "0x401575D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ShadowGO;

	[Token(Token = "0x401575E")]
	[FieldOffset(Offset = "0x4C")]
	public UISettingToggleGroup ShadowOpToggleGroup;

	[Token(Token = "0x401575F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject InGameFilter;

	[Token(Token = "0x4015760")]
	[FieldOffset(Offset = "0x54")]
	public UIToggleButton Filter2Btn;

	[Token(Token = "0x4015761")]
	[FieldOffset(Offset = "0x58")]
	public UIToggleButton Filter3Btn;

	[Token(Token = "0x4015762")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggleButton Filter4Btn;

	[Token(Token = "0x4015763")]
	[FieldOffset(Offset = "0x60")]
	public UIToggleButton Filter1Btn;

	[Token(Token = "0x4015764")]
	[FieldOffset(Offset = "0x64")]
	public GameObject HightFPSGO;

	[Token(Token = "0x4015765")]
	[FieldOffset(Offset = "0x68")]
	public UISettingToggleGroup HighFPSToggleGroup;

	[Token(Token = "0x4015766")]
	[FieldOffset(Offset = "0x6C")]
	public UIToggle HighFPS_off;

	[Token(Token = "0x4015767")]
	[FieldOffset(Offset = "0x70")]
	public GameObject MiniMap;

	[Token(Token = "0x4015768")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButtonGroup MiniMapScaleAssist;

	[Token(Token = "0x4015769")]
	[FieldOffset(Offset = "0x78")]
	public UIToggleButton MiniMapScaleOff;

	[Token(Token = "0x401576A")]
	[FieldOffset(Offset = "0x7C")]
	public UIToggleButton MiniMapScaleOn;

	[Token(Token = "0x401576B")]
	[FieldOffset(Offset = "0x80")]
	public UIToggle NorthUpBtn;

	[Token(Token = "0x401576C")]
	[FieldOffset(Offset = "0x84")]
	public UIToggle ViewUpBtn;

	[Token(Token = "0x401576D")]
	[FieldOffset(Offset = "0x88")]
	public GameObject NotchScreen;

	[Token(Token = "0x401576E")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject TipsNotchScreen;

	[Token(Token = "0x401576F")]
	[FieldOffset(Offset = "0x90")]
	public UILabel TipNewModeLabel;

	[Token(Token = "0x4015770")]
	[FieldOffset(Offset = "0x94")]
	public GameObject EnemyFireHint;

	[Token(Token = "0x4015771")]
	[FieldOffset(Offset = "0x98")]
	public GameObject EnemyFootStepHint;

	[Token(Token = "0x4015772")]
	[FieldOffset(Offset = "0x9C")]
	public UISettingToggleGroup EnemyFireToggle;

	[Token(Token = "0x4015773")]
	[FieldOffset(Offset = "0xA0")]
	public UISettingToggleGroup EnemyFootStepToggle;

	[Token(Token = "0x60164C4")]
	[Address(RVA = "0x1CF6860", Offset = "0x1CF6860", VA = "0x1CF6860")]
	public UIGraphicSettingView()
	{
	}

	[Token(Token = "0x60164C5")]
	[Address(RVA = "0x1CF6868", Offset = "0x1CF6868", VA = "0x1CF6868", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164C6")]
	[Address(RVA = "0x1CF76A0", Offset = "0x1CF76A0", VA = "0x1CF76A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
