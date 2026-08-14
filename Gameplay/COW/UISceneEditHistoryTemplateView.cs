using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200234E")]
public class UISceneEditHistoryTemplateView : MonoBehaviour
{
	[Token(Token = "0x200234F")]
	private enum EHistoryType
	{
		[Token(Token = "0x400DC07")]
		EHistoryType_LatestPlayed,
		[Token(Token = "0x400DC08")]
		EHistoryType_HistoryMost
	}

	[Token(Token = "0x400DBF2")]
	[FieldOffset(Offset = "0xC")]
	private SceneEditSlotInfo m_SlotInfo;

	[Token(Token = "0x400DBF3")]
	[FieldOffset(Offset = "0x10")]
	private EHistoryType m_HistoryType;

	[Token(Token = "0x400DBF4")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Template;

	[Token(Token = "0x400DBF5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MapName;

	[Token(Token = "0x400DBF6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PlayedCnt;

	[Token(Token = "0x400DBF7")]
	[FieldOffset(Offset = "0x20")]
	public UISprite MapIcon;

	[Token(Token = "0x400DBF8")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture CNDMapIcon;

	[Token(Token = "0x400DBF9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GameMap;

	[Token(Token = "0x400DBFA")]
	[FieldOffset(Offset = "0x2C")]
	public UITexture GameBitMap;

	[Token(Token = "0x400DBFB")]
	[FieldOffset(Offset = "0x30")]
	public UITexture GameBitOutLineMap;

	[Token(Token = "0x400DBFC")]
	[FieldOffset(Offset = "0x34")]
	public UISprite GameItemIconSpr;

	[Token(Token = "0x400DBFD")]
	[FieldOffset(Offset = "0x38")]
	public UITexture GameMapBg;

	[Token(Token = "0x400DBFE")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ClickBtn;

	[Token(Token = "0x400DBFF")]
	[FieldOffset(Offset = "0x40")]
	public GameObject BG1;

	[Token(Token = "0x400DC00")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BG2;

	[Token(Token = "0x400DC01")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ModeTag;

	[Token(Token = "0x400DC02")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ModeTagLabel;

	[Token(Token = "0x400DC03")]
	[FieldOffset(Offset = "0x50")]
	public UITable ModeInfoContainer;

	[Token(Token = "0x400DC04")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SpecialMask;

	[Token(Token = "0x400DC05")]
	[FieldOffset(Offset = "0x58")]
	public UISprite WarningIcon;

	[Token(Token = "0x600C4B3")]
	[Address(RVA = "0x2D9C964", Offset = "0x2D9C964", VA = "0x2D9C964")]
	public UISceneEditHistoryTemplateView()
	{
	}

	[Token(Token = "0x600C4B4")]
	[Address(RVA = "0x2D9C96C", Offset = "0x2D9C96C", VA = "0x2D9C96C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600C4B5")]
	[Address(RVA = "0x2D9CAD4", Offset = "0x2D9CAD4", VA = "0x2D9CAD4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600C4B6")]
	[Address(RVA = "0x2D9CB5C", Offset = "0x2D9CB5C", VA = "0x2D9CB5C")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600C4B7")]
	[Address(RVA = "0x2D9ABD8", Offset = "0x2D9ABD8", VA = "0x2D9ABD8")]
	public void SetWidth(float width)
	{
	}

	[Token(Token = "0x600C4B8")]
	[Address(RVA = "0x2D9AC90", Offset = "0x2D9AC90", VA = "0x2D9AC90")]
	public void SetUIData(WorkshopLatestInfo info, int index)
	{
	}

	[Token(Token = "0x600C4B9")]
	[Address(RVA = "0x2D9B61C", Offset = "0x2D9B61C", VA = "0x2D9B61C")]
	public void SetUIData(WorkshopHistoryInfo info, int index)
	{
	}

	[Token(Token = "0x600C4BA")]
	[Address(RVA = "0x2D9D5FC", Offset = "0x2D9D5FC", VA = "0x2D9D5FC")]
	private void RefrehSpecialState(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x600C4BB")]
	[Address(RVA = "0x2D9D148", Offset = "0x2D9D148", VA = "0x2D9D148")]
	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x600C4BC")]
	[Address(RVA = "0x2D9D758", Offset = "0x2D9D758", VA = "0x2D9D758")]
	private void _003CRefreshCDNMapIcon_003Em__0()
	{
	}
}
