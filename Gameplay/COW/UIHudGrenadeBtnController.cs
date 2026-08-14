using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002768")]
internal class UIHudGrenadeBtnController : UIHudButtonBaseController
{
	[Token(Token = "0x2002769")]
	public enum ButtonType
	{
		[Token(Token = "0x400F356")]
		None,
		[Token(Token = "0x400F357")]
		Grenade,
		[Token(Token = "0x400F358")]
		Loadout,
		[Token(Token = "0x400F359")]
		BuildingIceWall,
		[Token(Token = "0x400F35A")]
		Landmine,
		[Token(Token = "0x400F35B")]
		FlashBomb,
		[Token(Token = "0x400F35C")]
		MiniSentry,
		[Token(Token = "0x400F35D")]
		BuildingBrickBlock,
		[Token(Token = "0x400F35E")]
		WaterBall,
		[Token(Token = "0x400F35F")]
		PaintSprayer,
		[Token(Token = "0x400F360")]
		Dummy,
		[Token(Token = "0x400F361")]
		SmokeGrenade,
		[Token(Token = "0x400F362")]
		Fireworks,
		[Token(Token = "0x400F363")]
		BigToyGrenade,
		[Token(Token = "0x400F364")]
		MagneticField,
		[Token(Token = "0x400F365")]
		PersonalUAV,
		[Token(Token = "0x400F366")]
		BuildingCraft,
		[Token(Token = "0x400F367")]
		FrozenGrenade,
		[Token(Token = "0x400F368")]
		SnowBall,
		[Token(Token = "0x400F369")]
		FlameFlask,
		[Token(Token = "0x400F36A")]
		SmokeFlask,
		[Token(Token = "0x400F36B")]
		MAX
	}

	[Token(Token = "0x200276A")]
	public enum EGrenadeType
	{
		[Token(Token = "0x400F36D")]
		Attack = 1,
		[Token(Token = "0x400F36E")]
		Defence
	}

	[Token(Token = "0x200276B")]
	public class GrenadeButtonData
	{
		[Token(Token = "0x400F36F")]
		[FieldOffset(Offset = "0x8")]
		public ButtonType type;

		[Token(Token = "0x400F370")]
		[FieldOffset(Offset = "0xC")]
		public int count;

		[Token(Token = "0x400F371")]
		[FieldOffset(Offset = "0x10")]
		public int itemtype;

		[Token(Token = "0x600F129")]
		[Address(RVA = "0x13325E8", Offset = "0x13325E8", VA = "0x13325E8")]
		public GrenadeButtonData(ButtonType t, int c, int it)
		{
		}
	}

	[Token(Token = "0x400F338")]
	[FieldOffset(Offset = "0x2C")]
	protected UIHudGrenadeBtnView m_View;

	[Token(Token = "0x400F339")]
	[FieldOffset(Offset = "0x30")]
	protected ButtonType curType;

	[Token(Token = "0x400F33A")]
	[FieldOffset(Offset = "0x34")]
	protected ButtonType m_RouletteType;

	[Token(Token = "0x400F33B")]
	[FieldOffset(Offset = "0x38")]
	protected int[] itemCount;

	[Token(Token = "0x400F33C")]
	[FieldOffset(Offset = "0x3C")]
	protected int[] itemType;

	[Token(Token = "0x400F33D")]
	[FieldOffset(Offset = "0x40")]
	protected int curcharge;

	[Token(Token = "0x400F33E")]
	[FieldOffset(Offset = "0x44")]
	protected int maxcharge;

	[Token(Token = "0x400F33F")]
	[FieldOffset(Offset = "0x48")]
	protected bool HasShownTutorial;

	[Token(Token = "0x400F340")]
	[FieldOffset(Offset = "0x4C")]
	protected List<UIHudGrenadeSubBtnController> m_SubBtns;

	[Token(Token = "0x400F341")]
	[FieldOffset(Offset = "0x50")]
	protected List<GrenadeButtonData> m_SubData;

	[Token(Token = "0x400F342")]
	[FieldOffset(Offset = "0x54")]
	protected bool m_ShowSub;

	[Token(Token = "0x400F343")]
	[FieldOffset(Offset = "0x58")]
	protected Vector3 m_DefaultPos;

	[Token(Token = "0x400F344")]
	[FieldOffset(Offset = "0x64")]
	protected Vector3 m_SpPos;

	[Token(Token = "0x400F345")]
	[FieldOffset(Offset = "0x70")]
	protected EGrenadeType m_ButtonType;

	[Token(Token = "0x400F346")]
	[FieldOffset(Offset = "0x74")]
	protected int m_HudGrenadeDirection;

	[Token(Token = "0x400F347")]
	[FieldOffset(Offset = "0x78")]
	protected int m_HudGrenadeDirection2D;

	[Token(Token = "0x400F348")]
	[FieldOffset(Offset = "0x7C")]
	protected int m_CustomGrenadeSlot;

	[Token(Token = "0x400F349")]
	[FieldOffset(Offset = "0x0")]
	public static float GrenadeMaxDragDis;

	[Token(Token = "0x400F34A")]
	[FieldOffset(Offset = "0x4")]
	private static float GrenadeMaxDragDisSquare;

	[Token(Token = "0x400F34B")]
	[FieldOffset(Offset = "0x8")]
	private static float GreandeQuickDragDis;

	[Token(Token = "0x400F34C")]
	[FieldOffset(Offset = "0xC")]
	private static float GrenadeQuickDragDisSquare;

	[Token(Token = "0x400F34D")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsPressed;

	[Token(Token = "0x400F34E")]
	[FieldOffset(Offset = "0x84")]
	private float m_PressTime;

	[Token(Token = "0x400F34F")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 m_GrenadeBtnOriginalPos;

	[Token(Token = "0x400F350")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 m_GrenadeBtnStartPos;

	[Token(Token = "0x400F351")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 m_CurDirection;

	[Token(Token = "0x400F352")]
	[FieldOffset(Offset = "0xAC")]
	private Camera m_Camera;

	[Token(Token = "0x400F353")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_GlobalTouchEnd;

	[Token(Token = "0x400F354")]
	[FieldOffset(Offset = "0xB4")]
	private List<GameObject> m_CircleList;

	[Token(Token = "0x600F0F2")]
	[Address(RVA = "0x1898A70", Offset = "0x1898A70", VA = "0x1898A70")]
	public UIHudGrenadeBtnController()
	{
	}

	[Token(Token = "0x600F0F3")]
	[Address(RVA = "0x1898C20", Offset = "0x1898C20", VA = "0x1898C20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F0F4")]
	[Address(RVA = "0x1898CC4", Offset = "0x1898CC4", VA = "0x1898CC4", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F0F5")]
	[Address(RVA = "0x1898D68", Offset = "0x1898D68", VA = "0x1898D68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F0F6")]
	[Address(RVA = "0x189A6C8", Offset = "0x189A6C8", VA = "0x189A6C8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F0F7")]
	[Address(RVA = "0x189A510", Offset = "0x189A510", VA = "0x189A510")]
	private void UpdateHudGrenadeDirectionValues()
	{
	}

	[Token(Token = "0x600F0F8")]
	[Address(RVA = "0x189A5E8", Offset = "0x189A5E8", VA = "0x189A5E8")]
	private void UpdateCustomGrenadeSlot()
	{
	}

	[Token(Token = "0x600F0F9")]
	[Address(RVA = "0x189AE14", Offset = "0x189AE14", VA = "0x189AE14", Slot = "37")]
	protected virtual void OnUpdateCustomGrenadeSlot()
	{
	}

	[Token(Token = "0x600F0FA")]
	[Address(RVA = "0x189AE68", Offset = "0x189AE68", VA = "0x189AE68", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F0FB")]
	[Address(RVA = "0x189B034", Offset = "0x189B034", VA = "0x189B034")]
	public static BMGBKEENCJH GetSlotType(ButtonType t)
	{
		return default(BMGBKEENCJH);
	}

	[Token(Token = "0x600F0FC")]
	[Address(RVA = "0x189B0A8", Offset = "0x189B0A8", VA = "0x189B0A8")]
	public static ButtonType GetButtonType(BMGBKEENCJH type)
	{
		return default(ButtonType);
	}

	[Token(Token = "0x600F0FD")]
	[Address(RVA = "0x189B208", Offset = "0x189B208", VA = "0x189B208")]
	protected void OnSideWeaponChange(object[] param)
	{
	}

	[Token(Token = "0x600F0FE")]
	[Address(RVA = "0x189B4F4", Offset = "0x189B4F4", VA = "0x189B4F4")]
	public void SetGrenadeType(EGrenadeType type)
	{
	}

	[Token(Token = "0x600F0FF")]
	[Address(RVA = "0x189B730", Offset = "0x189B730", VA = "0x189B730")]
	protected void GenerateSubDatas()
	{
	}

	[Token(Token = "0x600F100")]
	[Address(RVA = "0x189BAC0", Offset = "0x189BAC0", VA = "0x189BAC0")]
	protected void ShowSubButtons()
	{
	}

	[Token(Token = "0x600F101")]
	[Address(RVA = "0x189B3E0", Offset = "0x189B3E0", VA = "0x189B3E0")]
	protected void HideSubButtons()
	{
	}

	[Token(Token = "0x600F102")]
	[Address(RVA = "0x189C06C", Offset = "0x189C06C", VA = "0x189C06C")]
	private void InternalSetSubBtnsVisible(bool isShow)
	{
	}

	[Token(Token = "0x600F103")]
	[Address(RVA = "0x189C350", Offset = "0x189C350", VA = "0x189C350")]
	protected void ToggleSubBtn()
	{
	}

	[Token(Token = "0x600F104")]
	[Address(RVA = "0x189C510", Offset = "0x189C510", VA = "0x189C510", Slot = "33")]
	protected override void OnBtnClick()
	{
	}

	[Token(Token = "0x600F105")]
	[Address(RVA = "0x189C738", Offset = "0x189C738", VA = "0x189C738")]
	protected void OnArrowClick()
	{
	}

	[Token(Token = "0x600F106")]
	[Address(RVA = "0x189C798", Offset = "0x189C798", VA = "0x189C798")]
	protected void RefreshArrow()
	{
	}

	[Token(Token = "0x600F107")]
	[Address(RVA = "0x189CC48", Offset = "0x189CC48", VA = "0x189CC48")]
	protected void OnNewItemOnHand(object[] param)
	{
	}

	[Token(Token = "0x600F108")]
	[Address(RVA = "0x189CE20", Offset = "0x189CE20", VA = "0x189CE20")]
	protected void GetButtonType(GFLDMEPHOFG itemType, AAHMJHHPECM itemOnHand, out ButtonType type, out bool showBtns)
	{
	}

	[Token(Token = "0x600F109")]
	[Address(RVA = "0x189D184", Offset = "0x189D184", VA = "0x189D184")]
	protected void ProcessNewTypeOnHand(ButtonType type, bool showBtns)
	{
	}

	[Token(Token = "0x600F10A")]
	[Address(RVA = "0x189E170", Offset = "0x189E170", VA = "0x189E170")]
	protected void RefreshButton(bool needFindNext = true)
	{
	}

	[Token(Token = "0x600F10B")]
	[Address(RVA = "0x18A0044", Offset = "0x18A0044", VA = "0x18A0044")]
	protected ButtonType FindNextType(ButtonType typeidx)
	{
		return default(ButtonType);
	}

	[Token(Token = "0x600F10C")]
	[Address(RVA = "0x18A03C4", Offset = "0x18A03C4", VA = "0x18A03C4")]
	protected void OnLandmineCountChange(object[] param)
	{
	}

	[Token(Token = "0x600F10D")]
	[Address(RVA = "0x18A04F8", Offset = "0x18A04F8", VA = "0x18A04F8")]
	protected void OnFireworksCountChange(object[] param)
	{
	}

	[Token(Token = "0x600F10E")]
	[Address(RVA = "0x18A062C", Offset = "0x18A062C", VA = "0x18A062C")]
	protected void OnBuildingCountChange(object[] param)
	{
	}

	[Token(Token = "0x600F10F")]
	[Address(RVA = "0x18A079C", Offset = "0x18A079C", VA = "0x18A079C")]
	protected void OnMiniSentryCountChange(object[] param)
	{
	}

	[Token(Token = "0x600F110")]
	[Address(RVA = "0x18A08D0", Offset = "0x18A08D0", VA = "0x18A08D0")]
	protected void OnDummyCountChange(object[] param)
	{
	}

	[Token(Token = "0x600F111")]
	[Address(RVA = "0x18A0A04", Offset = "0x18A0A04", VA = "0x18A0A04")]
	protected void OnMagneticFieldCountChange(object[] param)
	{
	}

	[Token(Token = "0x600F112")]
	[Address(RVA = "0x18A0B38", Offset = "0x18A0B38", VA = "0x18A0B38")]
	protected void OnPersonalUAVCountChange(object[] param)
	{
	}

	[Token(Token = "0x600F113")]
	[Address(RVA = "0x18A0C6C", Offset = "0x18A0C6C", VA = "0x18A0C6C")]
	protected void OnLoadoutCountChange(object[] param)
	{
	}

	[Token(Token = "0x600F114")]
	[Address(RVA = "0x18A0E10", Offset = "0x18A0E10", VA = "0x18A0E10")]
	protected void OnGrenadeCountChange(object[] param)
	{
	}

	[Token(Token = "0x600F115")]
	[Address(RVA = "0x18A1380", Offset = "0x18A1380", VA = "0x18A1380")]
	protected void OnLoadoutChargeChange(object[] param)
	{
	}

	[Token(Token = "0x600F116")]
	[Address(RVA = "0x189CAE0", Offset = "0x189CAE0", VA = "0x189CAE0")]
	protected void ShowTutorial()
	{
	}

	[Token(Token = "0x600F117")]
	[Address(RVA = "0x1899824", Offset = "0x1899824", VA = "0x1899824")]
	protected void OnDirectionChanged(object[] param)
	{
	}

	[Token(Token = "0x600F118")]
	[Address(RVA = "0x18A1744", Offset = "0x18A1744", VA = "0x18A1744")]
	protected void OnArrowClicked(object[] param)
	{
	}

	[Token(Token = "0x600F119")]
	[Address(RVA = "0x18A1838", Offset = "0x18A1838", VA = "0x18A1838")]
	protected void OnGrenadeSlotChanged(object[] param)
	{
	}

	[Token(Token = "0x600F11A")]
	[Address(RVA = "0x189E044", Offset = "0x189E044", VA = "0x189E044")]
	protected bool IsInSlotType(ButtonType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600F11B")]
	[Address(RVA = "0x189B588", Offset = "0x189B588", VA = "0x189B588")]
	protected bool CanButtonShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600F11C")]
	[Address(RVA = "0x18A026C", Offset = "0x18A026C", VA = "0x18A026C")]
	private void SetChargeProcessActive(bool visible)
	{
	}

	[Token(Token = "0x600F11D")]
	[Address(RVA = "0x18A1AC0", Offset = "0x18A1AC0", VA = "0x18A1AC0", Slot = "38")]
	protected virtual void InitRouletteAwake()
	{
	}

	[Token(Token = "0x600F11E")]
	[Address(RVA = "0x18A206C", Offset = "0x18A206C", VA = "0x18A206C")]
	private void UpdateAxisTouchingThroughArea()
	{
	}

	[Token(Token = "0x600F11F")]
	[Address(RVA = "0x18A23F8", Offset = "0x18A23F8", VA = "0x18A23F8", Slot = "39")]
	protected virtual void ShowRouletteGuide()
	{
	}

	[Token(Token = "0x600F120")]
	[Address(RVA = "0x18A2638", Offset = "0x18A2638", VA = "0x18A2638", Slot = "40")]
	protected virtual void RefreshGrenadeItemList(object[] data)
	{
	}

	[Token(Token = "0x600F121")]
	[Address(RVA = "0x18A29DC", Offset = "0x18A29DC", VA = "0x18A29DC")]
	private void OnRouletteGlobalTouchEnd(object[] data)
	{
	}

	[Token(Token = "0x600F122")]
	[Address(RVA = "0x18A2ACC", Offset = "0x18A2ACC", VA = "0x18A2ACC", Slot = "41")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600F124")]
	[Address(RVA = "0x18A3D68", Offset = "0x18A3D68", VA = "0x18A3D68")]
	private void _003COnLoadoutChargeChange_003Em__0()
	{
	}

	[Token(Token = "0x600F125")]
	[Address(RVA = "0x18A3DAC", Offset = "0x18A3DAC", VA = "0x18A3DAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F126")]
	[Address(RVA = "0x18A3DB4", Offset = "0x18A3DB4", VA = "0x18A3DB4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F127")]
	[Address(RVA = "0x18A3DBC", Offset = "0x18A3DBC", VA = "0x18A3DBC")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F128")]
	[Address(RVA = "0x18A3DC4", Offset = "0x18A3DC4", VA = "0x18A3DC4")]
	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}
}
