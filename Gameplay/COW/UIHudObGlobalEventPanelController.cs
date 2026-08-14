using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027DD")]
public class UIHudObGlobalEventPanelController : UIBaseController
{
	[Token(Token = "0x20027DE")]
	public struct GlobalEventItem
	{
		[Token(Token = "0x400F62C")]
		[FieldOffset(Offset = "0x0")]
		public byte eventID;

		[Token(Token = "0x400F62D")]
		[FieldOffset(Offset = "0x4")]
		public UILabel name;

		[Token(Token = "0x400F62E")]
		[FieldOffset(Offset = "0x8")]
		public UICheckboxButton checkBox;
	}

	[Token(Token = "0x400F61B")]
	private const string JumpHeight = "JumpHeight";

	[Token(Token = "0x400F61C")]
	private const string JumpHeightOne = "JumpHeightOne";

	[Token(Token = "0x400F61D")]
	private const string JumpHeightTwo = "JumpHeightTwo";

	[Token(Token = "0x400F61E")]
	private const string MovementSpeed = "MovementSpeed";

	[Token(Token = "0x400F61F")]
	private const string MovementSpeedOne = "MovementSpeedOne";

	[Token(Token = "0x400F620")]
	private const string MovementSpeedTwo = "MovementSpeedTwo";

	[Token(Token = "0x400F621")]
	private const string MovementSpeedThree = "MovementSpeedThree";

	[Token(Token = "0x400F622")]
	[FieldOffset(Offset = "0x28")]
	private UIHudObGlobalEventPanelView m_View;

	[Token(Token = "0x400F623")]
	[FieldOffset(Offset = "0x2C")]
	private int[] m_PollDurationOptions;

	[Token(Token = "0x400F624")]
	[FieldOffset(Offset = "0x30")]
	private int[] m_PollEventCountOptions;

	[Token(Token = "0x400F625")]
	[FieldOffset(Offset = "0x34")]
	private List<byte> m_EventIdListSelected;

	[Token(Token = "0x400F626")]
	[FieldOffset(Offset = "0x38")]
	private List<UICheckboxButton> m_CheckBoxList;

	[Token(Token = "0x400F627")]
	[FieldOffset(Offset = "0x3C")]
	private bool isCD;

	[Token(Token = "0x400F628")]
	[FieldOffset(Offset = "0x40")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400F629")]
	[FieldOffset(Offset = "0x44")]
	private LDAFPHICDJJ m_EventManager;

	[Token(Token = "0x400F62A")]
	[FieldOffset(Offset = "0x48")]
	private UIDetailTipsInGameController m_DetailTips;

	[Token(Token = "0x400F62B")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600F70D")]
	[Address(RVA = "0x1F5DB80", Offset = "0x1F5DB80", VA = "0x1F5DB80")]
	public UIHudObGlobalEventPanelController()
	{
	}

	[Token(Token = "0x600F70E")]
	[Address(RVA = "0x1F5DC6C", Offset = "0x1F5DC6C", VA = "0x1F5DC6C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F70F")]
	[Address(RVA = "0x1F5DD14", Offset = "0x1F5DD14", VA = "0x1F5DD14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F710")]
	[Address(RVA = "0x1F5F974", Offset = "0x1F5F974", VA = "0x1F5F974", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F711")]
	[Address(RVA = "0x1F5E3C4", Offset = "0x1F5E3C4", VA = "0x1F5E3C4")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600F712")]
	[Address(RVA = "0x1F602D0", Offset = "0x1F602D0", VA = "0x1F602D0")]
	private void SetJumpAndMove(RoomOBEventData oBEventData)
	{
	}

	[Token(Token = "0x600F713")]
	[Address(RVA = "0x1F60DC0", Offset = "0x1F60DC0", VA = "0x1F60DC0")]
	private void OnJumpSelectCallback(UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x600F714")]
	[Address(RVA = "0x1F60FBC", Offset = "0x1F60FBC", VA = "0x1F60FBC")]
	private void OnJumpUnSelectCallback(UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x600F715")]
	[Address(RVA = "0x1F611B8", Offset = "0x1F611B8", VA = "0x1F611B8")]
	private void OnMoveSelectCallback(UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x600F716")]
	[Address(RVA = "0x1F61488", Offset = "0x1F61488", VA = "0x1F61488")]
	private void OnMoveUnSelectCallback(UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x600F717")]
	[Address(RVA = "0x1F5FE78", Offset = "0x1F5FE78", VA = "0x1F5FE78")]
	private void OnJumpCheckClick()
	{
	}

	[Token(Token = "0x600F718")]
	[Address(RVA = "0x1F60088", Offset = "0x1F60088", VA = "0x1F60088")]
	private void OnMoveCheckClick()
	{
	}

	[Token(Token = "0x600F719")]
	[Address(RVA = "0x1F61758", Offset = "0x1F61758", VA = "0x1F61758")]
	private void Update()
	{
	}

	[Token(Token = "0x600F71A")]
	[Address(RVA = "0x1F61D1C", Offset = "0x1F61D1C", VA = "0x1F61D1C")]
	private void OnEventCheckBoxClick(object obj, int idx)
	{
	}

	[Token(Token = "0x600F71B")]
	[Address(RVA = "0x1F60C98", Offset = "0x1F60C98", VA = "0x1F60C98")]
	private void RefreshConfirmBtn()
	{
	}

	[Token(Token = "0x600F71C")]
	[Address(RVA = "0x1F5FAD8", Offset = "0x1F5FAD8", VA = "0x1F5FAD8")]
	private void OnPollCheckBoxClick()
	{
	}

	[Token(Token = "0x600F71D")]
	[Address(RVA = "0x1F6209C", Offset = "0x1F6209C", VA = "0x1F6209C")]
	private void OnSingleToggleClick()
	{
	}

	[Token(Token = "0x600F71E")]
	[Address(RVA = "0x1F621A4", Offset = "0x1F621A4", VA = "0x1F621A4")]
	private void OnMultipleToggleClick()
	{
	}

	[Token(Token = "0x600F71F")]
	[Address(RVA = "0x1F622AC", Offset = "0x1F622AC", VA = "0x1F622AC")]
	private void OnConfirm()
	{
	}

	[Token(Token = "0x600F720")]
	[Address(RVA = "0x1F61F54", Offset = "0x1F61F54", VA = "0x1F61F54")]
	private int GetMaxCheckableEventCount()
	{
		return default(int);
	}

	[Token(Token = "0x600F721")]
	[Address(RVA = "0x1F61810", Offset = "0x1F61810", VA = "0x1F61810")]
	private void RefreshCD()
	{
	}

	[Token(Token = "0x600F722")]
	[Address(RVA = "0x1F62AF0", Offset = "0x1F62AF0", VA = "0x1F62AF0")]
	private void OnCDEndNtf(object[] data)
	{
	}

	[Token(Token = "0x600F723")]
	[Address(RVA = "0x1F62B58", Offset = "0x1F62B58", VA = "0x1F62B58")]
	private void OnClose()
	{
	}

	[Token(Token = "0x600F724")]
	[Address(RVA = "0x1F62BC4", Offset = "0x1F62BC4", VA = "0x1F62BC4")]
	private void OnTipsClick()
	{
	}

	[Token(Token = "0x600F725")]
	[Address(RVA = "0x1F62F4C", Offset = "0x1F62F4C", VA = "0x1F62F4C")]
	private static bool _003CSetUIData_003Em__0(int m)
	{
		return default(bool);
	}

	[Token(Token = "0x600F726")]
	[Address(RVA = "0x1F62FF0", Offset = "0x1F62FF0", VA = "0x1F62FF0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F727")]
	[Address(RVA = "0x1F62FF8", Offset = "0x1F62FF8", VA = "0x1F62FF8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
